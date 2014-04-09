/// <reference path="jquery-2.1.0.js" />
/// <reference path="jquery-ui-1.10.4.js" />

geocoder = new google.maps.Geocoder();
var map;
$(function () {
    alert('Site Still under construction (04/02/14) - check back soon');
    $('._getLocation').click(function () {
        if (navigator.geolocation) {
            navigator.geolocation.getCurrentPosition(success, error);
        } else {
            error('not supported');
        }
    });
    $('#SearchSubmit').click(function () { MeetingSearch(); });
});

function success(position) {
    var latlng = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
    geocoder.geocode({ 'latLng': latlng }, function (results, status) {
        if (status == google.maps.GeocoderStatus.OK) {
            map.setCenter(results[0].geometry.location);
            map.setZoom(16);
            var marker = new google.maps.Marker({
                map: map,
                position: results[0].geometry.location,
                title: 'My Location (' + results[0].formatted_address + ')'
            });
            $('#Location').val('My Location (see map)');
            $('#longitude').val(latlng.lat());
            $('#latitude').val(latlng.lng());
        } else {
            alert("Geocoder failed due to: " + status);
        }
    });
}

function error() { alert('Could Not Locate You'); }

function initialize() {
    var mapOptions = {
        zoom: 14,
        center: new google.maps.LatLng(41.8819, -87.6278)
    };
    map = new google.maps.Map(document.getElementById('map'),
      mapOptions);
}

function MeetingSearch() {
    var longitude, latitude;

    //User clicked target icon - let app locate them, latlong stored in hidden field
    if ($('#Location').val() == 'My Location (see map)') { 
        longitude = $('#longitude').val();
        latitude = $('#latitude').val();
    }
    else  //Geocode user address input
    {       
        var address = $('#Location').val();
        geocoder.geocode({ 'address': address }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                longitude = results[0].geometry.location.lat();
                latitude = results[0].geometry.location.lng();
            }
            else // Google can't find user's input
            {
                alert('Can Not Locate Address Provided');
                return false;
            }
        }
        )
    }
    var radius = $('#Radius').val();
    var DayOfWeek = $('#DayOfWeek').val();
    $.ajax({
        url: "/Ajax/RadiusMeetingSearch",
        dataType: "json",
        data: { "radiusInMiles": radius, "latitude": latitude, "longitude": longitude, "DayOfWeek": DayOfWeek },
        success: function (response) {
            alert(response);
        }
    });
}
