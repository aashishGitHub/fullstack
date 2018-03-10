(function () {
    'use strict';

    angular
        .module('app')
        .controller('controller', controller);

    controller.$inject = ['$scope', 'factory','$q'];

    function controller($scope, factory, $q) {
        $scope.title = 'controller'; debugger;

        var deferred = $q.defer();
        $q.all([factory.getCookies()])
            .then(function (response) {
                debugger;
                angular.forEach(response, function (i, val) {
                    i.
                })
                $scope.cookies = response[0];
            })
       
        activate();

        function activate() { }
    }
})();
