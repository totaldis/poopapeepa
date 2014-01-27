(function () {
    'use strict';

    var coreModule = angular.module('core', []);

    coreModule.provider('coreConfig', function () {
        this.config = {
            controllerActivateSuccessEvent: ''
        };

        this.$get = function () {
            return {
                config: this.config
            };
        };
    });

    coreModule.factory('core',
        ['$q', '$rootScope', '$timeout', '$routeParams', 'coreConfig', 'logger', core]);

    function core($q, $rootScope, $timeout, $routeParams, coreConfig, logger) {
        var throttles = {};

        var service = {
            $broadcast: $broadcast,
            $q: $q,
            $timeout: $timeout,
            $routeParams: $routeParams,

            activateController: activateController,
            isNumber: isNumber,
            logger: logger,
            textContains: textContains
        };

        return service;

        function activateController(promises, controllerId) {
            return $q.all(promises).then(function (eventArgs) {
                var data = { controllerId: controllerId };
                $broadcast(coreConfig.config.controllerActivateSuccessEvent, data);
            });
        }

        function $broadcast() {
            return $rootScope.$broadcast.apply($rootScope, arguments);
        }

        function isNumber(val) {
            return /^[-]?\d+$/.test(val);
        }

        function textContains(text, searchText) {
            return text && -1 !== text.toLowerCase().indexOf(searchText.toLowerCase());
        }
    };

})();