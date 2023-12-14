import EditFormController from 'ember-flexberry/controllers/edit-form';

export default EditFormController.extend({
  parentRoute: 'i-i-s-vsempoka-докум-постав-l',

  getCellComponent(attr, bindingPath, model) {
    let cellComponent = this._super(...arguments);
    if (attr.kind === 'belongsTo') {
      switch (`${model.modelName}+${bindingPath}`) {
        case 'i-i-s-vsempoka-инфор-о-заказе+товары':
          cellComponent.componentProperties = {
            choose: 'showLookupDialog',
            remove: 'removeLookupValue',
            displayAttributeName: 'наимТовара',
            required: true,
            relationName: 'товары',
            projection: 'ТоварыL',
            autocomplete: true,
          };
          break;

      }
    }

    return cellComponent;
  },
});
