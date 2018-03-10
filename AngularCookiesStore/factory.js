(function () {
    'use strict';

    angular
        .module('app')
        .factory('factory', factory);

    factory.$inject = ['$http', '$q'];

    function factory($http, $q) {
        var service = {
            getCookies: getCookies
        };

        return service;
      

        function getCookies() {
            var deferred = $q.defer();

            return $http.get('http://localhost:61983/api/values')
                .then(function (response) {
                    // promise is fulfilled
                    deferred.resolve(response.data);
                    // promise is returned
                    return deferred.promise;
                }, function (response) {
                    // the following line rejects the promise 
                    deferred.reject(response);
                    // promise is returned
                    return deferred.promise;
                });          
        }
    }
})();