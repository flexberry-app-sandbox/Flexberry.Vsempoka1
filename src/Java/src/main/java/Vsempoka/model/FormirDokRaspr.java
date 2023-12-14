package Vsempoka.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Vsempoka.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;

import com.sap.olingo.jpa.metadata.core.edm.annotation.EdmIgnore;
import java.util.Date;

/**
 * Entity implementation class for Entity: ФормирДокРаспр
 */
@Entity(name = "IISVsempokaФормирДокРаспр")
@Table(schema = "public", name = "ФормирДокРаспр")
public class FormirDokRaspr {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "Дата")
    private Date дата;

    @Column(name = "НомерДокРаспред")
    private Integer номердокраспред;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "DokumPostav")
    @Convert("DokumPostav")
    @Column(name = "ДокумПостав", length = 16, unique = true, nullable = false)
    private UUID _dokumpostavid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "DokumPostav", insertable = false, updatable = false)
    private DokumPostav dokumpostav;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "SpisokKontej")
    @Convert("SpisokKontej")
    @Column(name = "СписокКонтей", length = 16, unique = true, nullable = false)
    private UUID _spisokkontejid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "SpisokKontej", insertable = false, updatable = false)
    private SpisokKontej spisokkontej;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "SpisokBarzh")
    @Convert("SpisokBarzh")
    @Column(name = "СписокБарж", length = 16, unique = true, nullable = false)
    private UUID _spisokbarzhid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "SpisokBarzh", insertable = false, updatable = false)
    private SpisokBarzh spisokbarzh;

    @EdmIgnore
    @Converter(converterClass = UUIDConverter.class, name = "PunktPogruzki")
    @Convert("PunktPogruzki")
    @Column(name = "ПунктПогрузки", length = 16, unique = true, nullable = false)
    private UUID _punktpogruzkiid;

    @ManyToOne(optional = false, fetch = FetchType.LAZY)
    @JoinColumn(name = "PunktPogruzki", insertable = false, updatable = false)
    private PunktPogruzki punktpogruzki;


    public FormirDokRaspr() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public Date getДата() {
      return дата;
    }

    public void setДата(Date дата) {
      this.дата = дата;
    }

    public Integer getНомерДокРаспред() {
      return номердокраспред;
    }

    public void setНомерДокРаспред(Integer номердокраспред) {
      this.номердокраспред = номердокраспред;
    }


}