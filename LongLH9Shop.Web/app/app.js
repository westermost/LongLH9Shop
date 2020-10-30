/// <reference path="../plugins/angular/angular.js" />

(function () {
    angular.module('longlh9shop', ['longlh9shop.common', 'longlh9shop.products']).config(config);

    config.$inject = ['$stateProvider', '$urlRouterProvider'];
    function config($stateProvider, $urlRouterProvider) {
        $stateProvider.state('home', {
            url: "/admin",
            templateUrl: "/app/components/home/homeView.html",
            controller: "homeController"
        });

        $urlRouterProvider.otherwise('/admin');
    }
})();