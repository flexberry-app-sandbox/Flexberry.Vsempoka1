import {
  defineNamespace,
  defineProjections,
  Model as ФормирДокРаспрMixin
} from '../mixins/regenerated/models/i-i-s-vsempoka-формир-док-распр';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ФормирДокРаспрMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
