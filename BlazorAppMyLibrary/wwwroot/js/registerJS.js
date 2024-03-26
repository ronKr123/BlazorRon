window.bootstrapjsinterop = {
    showModal: (modalSelector) => {
        // Show the Bootstrap modal
        $(modalSelector).modal('show');
    },

    disposeModal: (modalSelector) => {
        // Dispose of the Bootstrap modal reference to prevent memory leaks
        $(modalSelector).on('hidden.bs.modal', function (e) {
            $(this).data('bs.modal', null);
        });
    },

    disableBackButton: () => {
        // Disable browser back button
        window.history.pushState(null, document.title, window.location.href);
        window.addEventListener('popstate', function (event) {
            window.history.pushState(null, document.title, window.location.href);
        });
    }
};