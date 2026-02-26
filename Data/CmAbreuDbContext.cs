using ApiCm.Entities.Clientes;
using ApiCm.Entities.Compras;
using ApiCm.Entities.CuentasPorCobrar;
using ApiCm.Entities.Inventario;
using ApiCm.Entities.Ventas;
using Microsoft.EntityFrameworkCore;

namespace ApiCm.Data;

public class CmAbreuDbContext : DbContext
{
    public CmAbreuDbContext(DbContextOptions<CmAbreuDbContext> options)
        : base(options) { }

    // ==================== INVENTARIO ====================
    public DbSet<TBPRODUCTO> TBPRODUCTO { get; set; }
    public DbSet<TBPRDALM> TBPRDALM { get; set; }
    public DbSet<TBUNDPRCPRD> TBUNDPRCPRD { get; set; }
    public DbSet<TBTIPOINV> TBTIPOINV { get; set; }
    public DbSet<TBDIVISION> TBDIVISION { get; set; }
    public DbSet<TBCLASE> TBCLASE { get; set; }
    public DbSet<TBMARCA> TBMARCA { get; set; }
    public DbSet<TBUNDMEDIDA> TBUNDMEDIDA { get; set; }
    public DbSet<TBCPTINV> TBCPTINV { get; set; }
    public DbSet<TBPRDDEFECTO> TBPRDDEFECTO { get; set; }
    public DbSet<TBDETENTSAL> TBDETENTSAL { get; set; }
    public DbSet<TBINVFISICO> TBINVFISICO { get; set; }
    public DbSet<TBCABINVFIS> TBCABINVFIS { get; set; }
    public DbSet<TBDETINVFIS> TBDETINVFIS { get; set; }
    public DbSet<TBDETCMBPRC> TBDETCMBPRC { get; set; }
    public DbSet<TBREFMULTIPLE> TBREFMULTIPLE { get; set; }
    public DbSet<TBALMACEN> TBALMACEN { get; set; }
    public DbSet<TBCFGPRECIO> TBCFGPRECIO { get; set; }
    public DbSet<TBCABENTSAL> TBCABENTSAL { get; set; }
    public DbSet<TBCABTRFPRD> TBCABTRFPRD { get; set; }
    public DbSet<TBDETTRFPRD> TBDETTRFPRD { get; set; }
    public DbSet<TBCABCMBPRC> TBCABCMBPRC { get; set; }

    // ==================== COMPRAS ====================
    public DbSet<TBCPTLIQ> TBCPTLIQ { get; set; }
    public DbSet<TBLUGARENVCMP> TBLUGARENVCMP { get; set; }
    public DbSet<TBTIPODOCCMP> TBTIPODOCCMP { get; set; }
    public DbSet<TBDOCTOCMP> TBDOCTOCMP { get; set; }
    public DbSet<TBDETSOLCOT> TBDETSOLCOT { get; set; }
    public DbSet<TBCABORDCMP> TBCABORDCMP { get; set; }
    public DbSet<TBDETORDCMP> TBDETORDCMP { get; set; }
    public DbSet<TBDETCMPDEV> TBDETCMPDEV { get; set; }
    public DbSet<TBDETLIQMER> TBDETLIQMER { get; set; }
    public DbSet<TBCPTVALLIQ> TBCPTVALLIQ { get; set; }
    public DbSet<TBCABREQCMP> TBCABREQCMP { get; set; }
    public DbSet<TBDETREQCMP> TBDETREQCMP { get; set; }
    public DbSet<TBCABSOLCOT> TBCABSOLCOT { get; set; }
    public DbSet<TBCABCMPDEV> TBCABCMPDEV { get; set; }
    public DbSet<TBCABLIQMER> TBCABLIQMER { get; set; }

    // ==================== VENTAS ====================
    public DbSet<TBVENDEDOR> TBVENDEDOR { get; set; }
    public DbSet<TBZONA> TBZONA { get; set; }
    public DbSet<TBRUTA> TBRUTA { get; set; }
    public DbSet<TBCUOTAVENDEDOR> TBCUOTAVENDEDOR { get; set; }
    public DbSet<TBLUGARENVIOCTL> TBLUGARENVIOCTL { get; set; }
    public DbSet<TBREPART> TBREPART { get; set; }
    public DbSet<TBDESCTOCTEPRD> TBDESCTOCTEPRD { get; set; }
    public DbSet<TBTMPENTREGA> TBTMPENTREGA { get; set; }
    public DbSet<TBNOTADOCTO> TBNOTADOCTO { get; set; }
    public DbSet<TBCABFACREC> TBCABFACREC { get; set; }
    public DbSet<TBDETFACREC> TBDETFACREC { get; set; }
    public DbSet<TBTIPODOCVEN> TBTIPODOCVEN { get; set; }
    public DbSet<TBDOCTOVEN> TBDOCTOVEN { get; set; }
    public DbSet<TBCABCOTVEN> TBCABCOTVEN { get; set; }
    public DbSet<TBDETCOTVEN> TBDETCOTVEN { get; set; }
    public DbSet<TBCABPEDIDO> TBCABPEDIDO { get; set; }
    public DbSet<TBDETPEDIDO> TBDETPEDIDO { get; set; }
    public DbSet<TBCABCONDUCE> TBCABCONDUCE { get; set; }
    public DbSet<TBDETCONDUCE> TBDETCONDUCE { get; set; }
    public DbSet<TBDETFACDEV> TBDETFACDEV { get; set; }
    public DbSet<TBCUADRECAJA> TBCUADRECAJA { get; set; }
    public DbSet<TBVALCPTCUADRE> TBVALCPTCUADRE { get; set; }
    public DbSet<TBVALDNMCUADRE> TBVALDNMCUADRE { get; set; }
    public DbSet<TBCABFACDEV> TBCABFACDEV { get; set; }

    // ==================== CLIENTES ====================
    public DbSet<TBCLIENTE> TBCLIENTE { get; set; }
    public DbSet<TBCONCTE> TBCONCTE { get; set; }
    public DbSet<TBCONTACTO> TBCONTACTO { get; set; }
    public DbSet<TBCTEDEFECTO> TBCTEDEFECTO { get; set; }
    public DbSet<TBCIUDAD> TBCIUDAD { get; set; }
    public DbSet<TBGRPOCTE> TBGRPOCTE { get; set; }
    public DbSet<TBTIPOCTE> TBTIPOCTE { get; set; }
    public DbSet<TBTIPOCTEMON> TBTIPOCTEMON { get; set; }

    // ==================== CUENTAS POR COBRAR ====================
    public DbSet<TBTIPODOCCXC> TBTIPODOCCXC { get; set; }
    public DbSet<TBDOCTOCXC> TBDOCTOCXC { get; set; }
    public DbSet<TBCABMOVCXC> TBCABMOVCXC { get; set; }
    public DbSet<TBDETMOVCXC> TBDETMOVCXC { get; set; }
    public DbSet<TBCABRECIBO> TBCABRECIBO { get; set; }
    public DbSet<TBDETRECIBO> TBDETRECIBO { get; set; }
    public DbSet<TBCXCACT> TBCXCACT { get; set; }
    public DbSet<TBCXCHIS> TBCXCHIS { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // ==================== INVENTARIO - Keys ====================
        modelBuilder.Entity<TBPRODUCTO>(e =>
        {
            e.HasKey(x => new { x.PrdCompania, x.PrdCodigo });
        });

        modelBuilder.Entity<TBPRDALM>(e =>
        {
            e.HasKey(x => new
            {
                x.PalCompania,
                x.PrdCodigo,
                x.PalOficina,
                x.PalAlmacen,
            });
        });

        modelBuilder.Entity<TBUNDPRCPRD>(e =>
        {
            e.HasKey(x => new
            {
                x.UprCompania,
                x.PrdCodigo,
                x.UprSecuencia,
            });
        });

        modelBuilder.Entity<TBTIPOINV>(e =>
        {
            e.HasKey(x => new { x.TinCompania, x.TinCodigo });
        });

        modelBuilder.Entity<TBDIVISION>(e =>
        {
            e.HasKey(x => new { x.DivCompania, x.DivCodigo });
        });

        modelBuilder.Entity<TBCLASE>(e =>
        {
            e.HasKey(x => new { x.ClaCompania, x.ClaCodigo });
        });

        modelBuilder.Entity<TBMARCA>(e =>
        {
            e.HasKey(x => new { x.MarCompania, x.MarCodigo });
        });

        modelBuilder.Entity<TBUNDMEDIDA>(e =>
        {
            e.HasKey(x => new { x.UnmCompania, x.UnmCodigo });
        });

        modelBuilder.Entity<TBCPTINV>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.CinTipo,
                x.CinCodigo,
            });
        });

        modelBuilder.Entity<TBPRDDEFECTO>(e =>
        {
            e.HasKey(x => new { x.PddCompania });
        });

        modelBuilder.Entity<TBDETENTSAL>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.CinTipo,
                x.CinCodigo,
                x.CesNumero,
                x.DesSecuencia,
            });
        });

        modelBuilder.Entity<TBINVFISICO>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.AlmCodigo,
                x.IfsCompania,
                x.PrdCodigo,
            });
        });

        modelBuilder.Entity<TBCABINVFIS>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.CifNumero,
            });
        });

        modelBuilder.Entity<TBDETINVFIS>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.CifNumero,
                x.DifSecuencia,
            });
        });

        modelBuilder.Entity<TBDETCMBPRC>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.CcpNumero,
                x.DcpSecuencia,
            });
        });

        modelBuilder.Entity<TBREFMULTIPLE>(e =>
        {
            e.HasKey(x => new
            {
                x.PrdCompania,
                x.PrdCodigo,
                x.RefSecuencia,
            });
        });

        modelBuilder.Entity<TBALMACEN>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.AlmCodigo,
            });
        });

        modelBuilder.Entity<TBCFGPRECIO>(e =>
        {
            e.HasKey(x => new { x.CfpCompania, x.CfpCodigo });
        });

        modelBuilder.Entity<TBCABENTSAL>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.CinTipo,
                x.CinCodigo,
                x.CesNumero,
            });
        });

        modelBuilder.Entity<TBCABTRFPRD>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.CtpNumero,
            });
        });

        modelBuilder.Entity<TBDETTRFPRD>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.CtpNumero,
                x.DtpSecuencia,
            });
        });

        modelBuilder.Entity<TBCABCMBPRC>(e =>
        {
            e.HasKey(x => new { x.CiaCodigo, x.CcpNumero });
        });

        // ==================== COMPRAS - Keys ====================
        modelBuilder.Entity<TBCPTLIQ>(e =>
        {
            e.HasKey(x => new { x.CiaCodigo, x.CplCodigo });
        });

        modelBuilder.Entity<TBLUGARENVCMP>(e =>
        {
            e.HasKey(x => new { x.LepCompania, x.LepCodigo });
        });

        modelBuilder.Entity<TBTIPODOCCMP>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
            });
        });

        modelBuilder.Entity<TBDOCTOCMP>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
            });
        });

        modelBuilder.Entity<TBCABSOLCOT>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.CstNumero,
            });
        });

        modelBuilder.Entity<TBDETSOLCOT>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.CstNumero,
                x.DstSecuencia,
            });
        });

        modelBuilder.Entity<TBCABORDCMP>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.CocNumero,
            });
        });

        modelBuilder.Entity<TBDETORDCMP>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.CocNumero,
                x.DocSecuencia,
            });
        });

        modelBuilder.Entity<TBCABREQCMP>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.CrpNumero,
            });
        });

        modelBuilder.Entity<TBDETREQCMP>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.CrpNumero,
                x.DrpSecuencia,
            });
        });

        modelBuilder.Entity<TBCABCMPDEV>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.CcdNumero,
            });
        });

        modelBuilder.Entity<TBDETCMPDEV>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.CcdNumero,
                x.DcdSecuencia,
            });
        });

        modelBuilder.Entity<TBCABLIQMER>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.ClqNumero,
            });
        });

        modelBuilder.Entity<TBDETLIQMER>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.ClqNumero,
                x.DlqSecuencia,
            });
        });

        modelBuilder.Entity<TBCPTVALLIQ>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdmTipo,
                x.TdmCodigo,
                x.DcmAno,
                x.ClqNumero,
                x.CplCodigo,
            });
        });

        // ==================== VENTAS - Keys ====================
        modelBuilder.Entity<TBVENDEDOR>(e =>
        {
            e.HasKey(x => new { x.CiaCodigo, x.VenCodigo });
        });

        modelBuilder.Entity<TBZONA>(e =>
        {
            e.HasKey(x => x.ZnaCodigo);
        });

        modelBuilder.Entity<TBRUTA>(e =>
        {
            e.HasKey(x => new { x.CiaCodigo, x.RutCodigo });
        });

        modelBuilder.Entity<TBCUOTAVENDEDOR>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.VenCodigo,
                x.CvnAno,
            });
        });

        modelBuilder.Entity<TBLUGARENVIOCTL>(e =>
        {
            e.ToTable("TBLUGARENVIOCTL");
            e.HasKey(x => new { x.LecCompania, x.LecCodigo });
        });

        modelBuilder.Entity<TBREPART>(e =>
        {
            e.HasKey(x => new { x.RepCompania, x.RepCodigo });
        });

        modelBuilder.Entity<TBDESCTOCTEPRD>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.CteCodigo,
                x.MonCodigo,
                x.DspSecuencia,
            });
        });

        modelBuilder.Entity<TBTMPENTREGA>(e =>
        {
            e.HasKey(x => new { x.TenCompania, x.TenCodigo });
        });

        modelBuilder.Entity<TBNOTADOCTO>(e =>
        {
            e.HasKey(x => new
            {
                x.NdmCompania,
                x.NdmModulo,
                x.NdmCodigo,
            });
        });

        modelBuilder.Entity<TBCABFACREC>(e =>
        {
            e.ToTable("TBCABFACREC");
            e.HasKey(x => new
            {
                x.FrcCompania,
                x.FrcTipo,
                x.FrcNumero,
            });
        });

        modelBuilder.Entity<TBDETFACREC>(e =>
        {
            e.ToTable("TBDETFACREC");
            e.HasKey(x => new
            {
                x.FrcCompania,
                x.FrcTipo,
                x.FrcNumero,
                x.FrcLinea,
            });
        });

        modelBuilder.Entity<TBTIPODOCVEN>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
            });
        });

        modelBuilder.Entity<TBDOCTOVEN>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
            });
        });

        modelBuilder.Entity<TBCABCOTVEN>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
                x.CcvNumero,
            });
        });

        modelBuilder.Entity<TBDETCOTVEN>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
                x.CcvNumero,
                x.DcvSecuencia,
            });
        });

        modelBuilder.Entity<TBCABPEDIDO>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
                x.CpeNumero,
            });
        });

        modelBuilder.Entity<TBDETPEDIDO>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
                x.CpeNumero,
                x.DpeSecuencia,
            });
        });

        modelBuilder.Entity<TBCABCONDUCE>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
                x.CcnNumero,
            });
        });

        modelBuilder.Entity<TBDETCONDUCE>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
                x.CcnNumero,
                x.DcnSecuencia,
            });
        });

        modelBuilder.Entity<TBDETFACDEV>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
                x.CfdNumero,
                x.DfdSecuencia,
            });
        });

        modelBuilder.Entity<TBCUADRECAJA>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.CajCodigo,
                x.MonCodigo,
                x.CjcFecha,
            });
        });

        modelBuilder.Entity<TBVALCPTCUADRE>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.CajCodigo,
                x.MonCodigo,
                x.CjcFecha,
                x.CjcCodigo,
            });
        });

        modelBuilder.Entity<TBVALDNMCUADRE>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.CajCodigo,
                x.MonCodigo,
                x.OfiCodigo,
                x.CjcFecha,
                x.DnmCodigo,
            });
        });

        modelBuilder.Entity<TBCABFACDEV>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdvTipo,
                x.TdvCodigo,
                x.DnvAno,
                x.CfdNumero,
            });
        });

        // ==================== CLIENTES - Keys ====================
        modelBuilder.Entity<TBCLIENTE>(e =>
        {
            e.ToTable("TBCLIENTE");
            e.HasKey(x => new { x.CiaCodigo, x.CteCodigo });
        });

        modelBuilder.Entity<TBCONCTE>(e =>
        {
            e.ToTable("TBCONCTE");
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.CteCodigo,
                x.CclCodigo,
            });
        });

        modelBuilder.Entity<TBCONTACTO>(e =>
        {
            e.ToTable("TBCONTACTO");
            e.HasKey(x => new { x.CiaCodigo, x.ConCodigo });
        });

        modelBuilder.Entity<TBCTEDEFECTO>(e =>
        {
            e.ToTable("TBCTEDEFECTO");
            e.HasKey(x => new { x.CiaCodigo, x.CdfLocalExterior });
        });

        modelBuilder.Entity<TBCIUDAD>(e =>
        {
            e.ToTable("TBCIUDAD");
            e.HasKey(x => x.CdaCodigo);
        });

        modelBuilder.Entity<TBGRPOCTE>(e =>
        {
            e.ToTable("TBGRPOCTE");
            e.HasKey(x => new { x.CiaCodigo, x.GctCodigo });
        });

        modelBuilder.Entity<TBTIPOCTE>(e =>
        {
            e.ToTable("TBTIPOCTE");
            e.HasKey(x => new { x.CiaCodigo, x.TclCodigo });
        });

        modelBuilder.Entity<TBTIPOCTEMON>(e =>
        {
            e.ToTable("TBTIPOCTEMON");
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.TclCodigo,
                x.MonCodigo,
            });
        });

        // ==================== CUENTAS POR COBRAR - Keys ====================
        modelBuilder.Entity<TBTIPODOCCXC>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.MonCodigo,
                x.TdcTipo,
                x.TdcCodigo,
            });
        });

        modelBuilder.Entity<TBDOCTOCXC>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdcTipo,
                x.TdcCodigo,
                x.DxcAno,
            });
        });

        modelBuilder.Entity<TBCABMOVCXC>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdcTipo,
                x.TdcCodigo,
                x.DxcAno,
                x.CmcNumero,
            });
        });

        modelBuilder.Entity<TBDETMOVCXC>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdcTipo,
                x.TdcCodigo,
                x.DxcAno,
                x.CmcNumero,
                x.DmcSecuencia,
            });
        });

        modelBuilder.Entity<TBCABRECIBO>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdcTipo,
                x.TdcCodigo,
                x.DxcAno,
                x.CrcNumero,
            });
        });

        modelBuilder.Entity<TBDETRECIBO>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.TdcTipo,
                x.TdcCodigo,
                x.DxcAno,
                x.CrcNumero,
                x.DrcSecuencia,
            });
        });

        modelBuilder.Entity<TBCXCACT>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.CcaModulo,
                x.CcaTipo,
                x.CcaCodigo,
                x.CcaAno,
                x.CcaNumero,
                x.CcaSecuencia,
                x.CcaSubsec,
            });
        });

        modelBuilder.Entity<TBCXCHIS>(e =>
        {
            e.HasKey(x => new
            {
                x.CiaCodigo,
                x.OfiCodigo,
                x.MonCodigo,
                x.CchModulo,
                x.CchTipo,
                x.CchCodigo,
                x.CchAno,
                x.CchNumero,
                x.CchSecuencia,
                x.CchSubsec,
            });
        });
    }
}
