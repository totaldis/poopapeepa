// Define configuration settings for application.

(function () {
    'use strict';

    var app = angular.module('app');

    var breezeApiName = 'http://localhost:1526/breeze/data';

    var events = {
        controllerActivateSuccess: 'controller.activateSuccess'
    };

    var config = {
        errorPrefix: '[pp Error] ',
        events: events,
        serviceName: breezeApiName,
        version: '0.1.0'
    };

    app.value('config', config);

    app.config(['$logProvider', function ($logProvider) {
        if ($logProvider.debugEnabled) {
            $logProvider.debugEnabled(true);
        }
    }]);

    app.config(['coreConfigProvider', function (ccfg) {
        ccfg.config.controllerActivateSuccessEvent = config.events.controllerActivateSuccess;
    }]);

})();