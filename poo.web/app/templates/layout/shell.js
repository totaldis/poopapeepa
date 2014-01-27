(function () {
    'use strict';

    var controllerId = 'shell';
    angular.module('app').controller(controllerId,
        ['$rootScope', 'core', 'config', shell]);

    function shell($rootScope, core, config) {
        var vm = this;
        var logSuccess = core.logger.getLogFn(controllerId, 'success');
        var events = config.events;
        vm.busyMessage = 'Please wait ...';
        vm.isBusy = true;

        activate();

        function activate() {
            core.activateController([], controllerId);
            logSuccess('poopapeepa loaded!', null, true);
        }

        function toggleLoader(on) { vm.isBusy = on; }

        $rootScope.$on('$routeChangeStart',
            function (event, next, current) { toggleLoader(true); }
        );

        $rootScope.$on(events.controllerActivateSuccess,
            function (data) { toggleLoader(false); }
        );
    };
})();