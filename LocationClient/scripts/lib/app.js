 ///<reference path="angular.js"/>
var locationApp = angular.module('locationApp', []);
var locationController = locationApp.controller('locationController', function ($scope, $http)
{
    $scope.getLocation=function()
    {
        $http.get("https://localhost:44375/api/location?cityName=abc").then(function (response) {
            $scope.city = response.data;
            ;
        });
    }
});