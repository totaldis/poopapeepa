﻿(function () {
    'use strict';

    var app = angular.module('app');
    app.constant('routes', getRoutes());

    app.config(['$routeProvider', 'routes', routeConfigurator]);
    function routeConfigurator($routeProvider, routes) {
        routes.forEach(function (r) {
            $routeProvider.when(r.url, r.config);
        });
        $routeProvider.otherwise({ redirectTo: '/' });
    }

    function getRoutes() {
        return [
            {
                url: '/',
                config: {
                    templateUrl: 'app/templates/dashboard/index.html',
                    title: 'Lab Home',
                    settings: {}
                }
            }
        ]
    }
})();