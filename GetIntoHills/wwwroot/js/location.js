function initialize() {
    var latlng = new google.maps.LatLng(40.716948, -74.003563);
    var options = {
        zoom: 14, center: latlng,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById
        ("map"), options);
}
function showMap() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(function (position) {
            var latLng = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
            var mapOptions = {
                center: latLng,
                zoom: 12
            };
            var map = new google.maps.Map(document.getElementById("map"), mapOptions);
            var marker = new google.maps.Marker({
                position: latLng,
                map: map,
                title: "Your current location"
            });
        }, function (error) {
            // Handle geolocation error
            switch (error.code) {
                case error.PERMISSION_DENIED:
                    alert("User denied the request for Geolocation.");
                    break;
                case error.POSITION_UNAVAILABLE:
                    alert("Location information is unavailable.");
                    break;
                case error.TIMEOUT:
                    alert("The request to get user location timed out.");
                    break;
                case error.UNKNOWN_ERROR:
                    alert("An unknown error occurred.");
                    break;
            }
        }, {
            enableHighAccuracy: true,
            timeout: 5000,
            maximumAge: 0
        });
    } else {
        alert("Geolocation is not supported by this browser.");
    }
}

function initAutocomplete() {
    // Get the input element
    var input = document.getElementById("from");
    var input1 = document.getElementById("to");

    // Create the autocomplete object
    var autocomplete = new google.maps.places.Autocomplete(input);
    var autocomplete1 = new google.maps.places.Autocomplete(input1);

    // Restrict the search to only return addresses
    autocomplete.setTypes(['address']);
    autocomplete1.setTypes(['address']);

    // Listen for the "place_changed" event
    autocomplete.addListener("place_changed", function () {
        // Get the selected place from the autocomplete object
        var place = autocomplete.getPlace();

        // Do something with the selected place, e.g. display the name in a div
        document.getElementById("placeName").innerHTML = place.name;
    });
    // Listen for the "place_changed" event
    autocomplete1.addListener("place_changed", function () {
        // Get the selected place from the autocomplete object
        var place = autocomplete1.getPlace();

        // Do something with the selected place, e.g. display the name in a div
        document.getElementById("placeName").innerHTML = place.name;
    });
}

function calculateDistance() {
    // Get the start and end addresses from the form inputs
    const startAddress = document.getElementById('from').value;
    const endAddress = document.getElementById('to').value;

    // Create a new Google Maps DirectionsService object
    const directionsService = new google.maps.DirectionsService();

    // Create a new Google Maps DirectionsRenderer object to display the directions
    const directionsRenderer = new google.maps.DirectionsRenderer();

    // Create a new Google Maps Map object
    const map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: 37.7749, lng: -122.4194 },
        zoom: 13,
    });

    // Set the map property of the DirectionsRenderer object to the newly created Map object
    directionsRenderer.setMap(map);

    // Set the panel property of the DirectionsRenderer object to the HTML element that will display the directions
    directionsRenderer.setPanel(document.getElementById('directions'));

    // Use the DirectionsService object to request directions from the start address to the end address
    directionsService.route({
        origin: startAddress,
        destination: endAddress,
        travelMode: 'DRIVING',
    }, (response, status) => {
        if (status === 'OK') {
            // Display the directions on the map using the DirectionsRenderer object
            directionsRenderer.setDirections(response);

            // Calculate the total distance of the route in meters
            const totalDistance = response.routes[0].legs.reduce((total, leg) => {
                return total + leg.distance.value;
            }, 0);

            // Calculate the total duration of the route in meters
            const totalduration = response.routes[0].legs[0].duration.value / 3600;

            // Convert the distance from meters to miles
            const totalDistanceMiles = totalDistance / 1000;

            // Display the total distance on the page
            document.getElementById('distance').textContent = `Total Distance: ${totalDistanceMiles.toFixed(2)} miles`;

            // Display the total Duration on the page
            document.getElementById('Duration').textContent = `Total Duration: ${totalduration} hours`;

        } else {
            // Display an error message if the request failed
            alert(`Directions request failed due to ${status}`);
        }
    });
}





