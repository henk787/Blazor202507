// By Brian Parker
// https://stackoverflow.com/a/72872888

export function getCurrentPosition(dotNetHelper) {

    const options = {
        enableHighAccuracy: true,
        timeout: 5000,
        maximumAge: 0
    };

    function success(pos) {

        const coord = { // because: pos.coords is not serializable
            latitude: pos.coords.latitude,
            longitude: pos.coords.longitude,
            accuracy: pos.coords.accuracy
        };

        dotNetHelper.invokeMethodAsync('OnSuccessAsync', coord);
    }


    function error(err) {
        console.log(err.code);
        console.log(err.message);
        console.warn('ERROR(${err.code}): ${err.message}');
    }
        
    navigator.geolocation.getCurrentPosition(success, error, options);
}