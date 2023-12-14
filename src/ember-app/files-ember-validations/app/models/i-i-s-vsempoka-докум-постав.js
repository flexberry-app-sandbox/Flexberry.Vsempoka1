import {
  defineNamespace,
  defineProjections,
  Model as ДокумПоставMixin
} from '../mixins/regenerated/models/i-i-s-vsempoka-докум-постав';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(ДокумПоставMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
