﻿(function () {
    var ResponsiveText, delayedAdjust, responsiveTextIndex;

    delayedAdjust = [];

    responsiveTextIndex = 0;

    ResponsiveText = (function () {
        function ResponsiveText(el) {
            this.index = responsiveTextIndex++;
            this.el = el;
            this.compression = $(this.el).data('compression') || 10;
            this.minFontSize = $(this.el).data('min') || Number.NEGATIVE_INFINITY;
            this.maxFontSize = $(this.el).data('max') || Number.POSITIVE_INFINITY;
            this.scrollable = $(this.el).data('scrollable') || false;
            this.scrollSpeed = $(this.el).data('scrollspeed') || 650;
            this.scrollReset = $(this.el).data('scrollreset') || 200;
            this.init();
        }

        ResponsiveText.prototype.init = function () {
            $(this.el).wrapInner('<span class="responsiveText-wrapper" />');
            this.adjustOnLoad();
            this.adjustOnResize();
            if (this.scrollable) {
                return this.scrollOnHover();
            }
        };

        ResponsiveText.prototype.resizeText = function () {
            return $(this.el).css("font-size", Math.floor(Math.max(Math.min($(this.el).width() / this.compression, this.maxFontSize), this.minFontSize)));
        };

        ResponsiveText.prototype.adjustOnLoad = function () {
            var _this = this;
            return $(window).on('load', function () {
                return _this.resizeText();
            });
        };

        ResponsiveText.prototype.adjustOnResize = function () {
            var _this = this;
            return $(window).on('resize', function () {
                clearTimeout(delayedAdjust[_this.index]);
                return delayedAdjust[_this.index] = setTimeout(function () {
                    return _this.resizeText();
                }, 20);
            });
        };

        ResponsiveText.prototype.scrollOnHover = function () {
            var _this = this;
            $(this.el).css({
                'overflow': 'hidden',
                'text-overflow': 'ellipsis',
                'white-space': 'nowrap'
            });
            return $(this.el).hover(function () {
                _this.difference = _this.el.scrollWidth - $(_this.el).width();
                if (_this.difference > _this.scrollSpeed) {
                    _this.scrollSpeed = _this.difference;
                }
                if (_this.difference > 0) {
                    $(_this.el).css('cursor', 'e-resize');
                    return $(_this.el).stop().animate({
                        "text-indent": -_this.difference
                    }, _this.scrollSpeed, function () {
                        return $(_this.el).css('cursor', 'text');
                    });
                }
            }, function () {
                return $(_this.el).stop().animate({
                    "text-indent": 0
                }, _this.scrollReset);
            });
        };

        return ResponsiveText;

    })();

    (function ($) {
        var responsiveTextElements;
        responsiveTextElements = [];
        return $.fn.responsiveText = function (options) {
            return this.each(function () {
                return responsiveTextElements.push(new ResponsiveText(this));
            });
        };
    })(jQuery);

}).call(this);