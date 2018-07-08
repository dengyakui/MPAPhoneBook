(function() {
    $(function() {
        var personService = abp.services.app.person;
        var $modal = $("#PersonCreateModal");
        var $form = $modal.find("form");

        $form.find('button[type="submit"]').click(function(e) {
            e.preventDefault();
            if (!$form.valid()) {
                return;
            }

            var personEditDto = $form.serializeFormToObject(); // 序列化表单为对象

            abp.ui.setBusy($modal);
            personService.createOrUpdate({ personEditDto })
                .done(function() {
                    $modal.modal('hide');
                    location.reload();
                }).always(function() {
                    abp.ui.clearBusy($modal);
                });

        })


    });
})();