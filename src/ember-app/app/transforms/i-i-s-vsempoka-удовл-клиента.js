import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import УдовлКлиентаEnum from '../enums/i-i-s-vsempoka-удовл-клиента';

export default FlexberryEnum.extend({
  enum: УдовлКлиентаEnum,
  sourceType: 'IIS.Vsempoka.УдовлКлиента'
});
