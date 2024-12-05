using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ShowTime_DatabseProject.Models;

public partial class DbTeamSmileShowInfantilContext : DbContext
{
    public DbTeamSmileShowInfantilContext()
    {
    }

    public DbTeamSmileShowInfantilContext(DbContextOptions<DbTeamSmileShowInfantilContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<EstadoEmpleado> EstadoEmpleados { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<EventoServicio> EventoServicios { get; set; }

    public virtual DbSet<Pago> Pagos { get; set; }

    public virtual DbSet<Paquete> Paquetes { get; set; }

    public virtual DbSet<PaqueteServicio> PaqueteServicios { get; set; }

    public virtual DbSet<RolEmpleadoEvento> RolEmpleadoEventos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<ServicioUtilerium> ServicioUtileria { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Utilerium> Utileria { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-2308JBE;Database=DB_TeamSmile_ShowInfantil;Trusted_Connection=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.IdCargo).HasName("PK__Cargos__170A99B48EEA8684");

            entity.Property(e => e.IdCargo).HasColumnName("Id_cargo");
            entity.Property(e => e.NombreCargo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_cargo");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Clientes__FCE03992ED180FE7");

            entity.HasIndex(e => e.CorreoElectronico, "UC_Correo").IsUnique();

            entity.HasIndex(e => e.Telefono, "UC_Telefono").IsUnique();

            entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CorreoElectronico)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Correo_electronico");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.IdEmpleado).HasName("PK__Empleado__01AC28293352ED90");

            entity.HasIndex(e => e.Email, "UC_Email").IsUnique();

            entity.HasIndex(e => e.Telefono, "UC_telefono_Empleado").IsUnique();

            entity.Property(e => e.IdEmpleado).HasColumnName("Id_empleado");
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EstadoEmpleado)
                .HasDefaultValue(3)
                .HasColumnName("Estado_Empleado");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.EstadoEmpleadoNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.EstadoEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleados_Estado_Empleado");
        });

        modelBuilder.Entity<EstadoEmpleado>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK__Estado_E__AD3E5E1BF8D282B5");

            entity.ToTable("Estado_Empleado");

            entity.Property(e => e.IdEstado).HasColumnName("Id_estado");
            entity.Property(e => e.TipoEstado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Tipo_estado");
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.IdEvento).HasName("PK__Eventos__D44FA6DE32066FE8");

            entity.Property(e => e.IdEvento).HasColumnName("Id_evento");
            entity.Property(e => e.CantidadDeAsistentes).HasColumnName("Cantidad_de_asistentes");
            entity.Property(e => e.CostoTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Costo_total");
            entity.Property(e => e.DetallesAdicionales)
                .IsUnicode(false)
                .HasColumnName("Detalles_adicionales");
            entity.Property(e => e.Direccion).HasColumnType("text");
            entity.Property(e => e.Estado)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("Pendiente");
            entity.Property(e => e.FechaInicio).HasColumnName("Fecha_inicio");
            entity.Property(e => e.FechaReserva).HasColumnName("Fecha_reserva");
            entity.Property(e => e.HoraFin).HasColumnName("Hora_fin");
            entity.Property(e => e.HoraInicio).HasColumnName("Hora_inicio");
            entity.Property(e => e.IdCliente).HasColumnName("Id_cliente");
            entity.Property(e => e.IdPaquete).HasColumnName("Id_paquete");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Eventos_Clientes");

            entity.HasOne(d => d.IdPaqueteNavigation).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.IdPaquete)
                .HasConstraintName("FK_Evento_Paquete");
        });

        modelBuilder.Entity<EventoServicio>(entity =>
        {
            entity.HasKey(e => e.IdEventoServicios).HasName("PK__Evento_S__5E210511B93A456A");

            entity.ToTable("Evento_Servicios");

            entity.Property(e => e.IdEventoServicios).HasColumnName("Id_evento_servicios");
            entity.Property(e => e.IdEvento).HasColumnName("Id_evento");
            entity.Property(e => e.IdServicio).HasColumnName("Id_servicio");

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.EventoServicios)
                .HasForeignKey(d => d.IdEvento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evento_Servicios_Eventos");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.EventoServicios)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Evento_Servicios_Servicios");
        });

        modelBuilder.Entity<Pago>(entity =>
        {
            entity.HasKey(e => e.IdPago).HasName("PK__Pagos__405F9B772C65B964");

            entity.Property(e => e.IdPago).HasColumnName("Id_pago");
            entity.Property(e => e.FechaPago).HasColumnName("Fecha_pago");
            entity.Property(e => e.IdEvento).HasColumnName("Id_evento");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Metodo_pago");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.Pagos)
                .HasForeignKey(d => d.IdEvento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pagos_ReservacionEvento");
        });

        modelBuilder.Entity<Paquete>(entity =>
        {
            entity.HasKey(e => e.IdPaquete).HasName("PK__Paquetes__C967EF22AB6C5FAB");

            entity.Property(e => e.IdPaquete).HasColumnName("Id_paquete");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion).IsUnicode(false);
            entity.Property(e => e.NombrePaquete)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_paquete");
        });

        modelBuilder.Entity<PaqueteServicio>(entity =>
        {
            entity.HasKey(e => e.IdPaqueteServicios).HasName("PK__Paquete___B42790D04337FDE8");

            entity.ToTable("Paquete_Servicios");

            entity.Property(e => e.IdPaqueteServicios).HasColumnName("Id_paquete_servicios");
            entity.Property(e => e.IdPaquete).HasColumnName("Id_paquete");
            entity.Property(e => e.IdServicio).HasColumnName("Id_servicio");

            entity.HasOne(d => d.IdPaqueteNavigation).WithMany(p => p.PaqueteServicios)
                .HasForeignKey(d => d.IdPaquete)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Paquete_Servicios_Paquetes");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.PaqueteServicios)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Paquete_Servicios_Servicios");
        });

        modelBuilder.Entity<RolEmpleadoEvento>(entity =>
        {
            entity.HasKey(e => e.IdRolEmpleadoEvento).HasName("PK__Rol_Empl__2950BF2FB765570E");

            entity.ToTable("Rol_Empleado_Evento");

            entity.Property(e => e.IdRolEmpleadoEvento).HasColumnName("Id_rol_empleado_evento");
            entity.Property(e => e.IdEmpleado).HasColumnName("Id_empleado");
            entity.Property(e => e.IdEvento).HasColumnName("Id_evento");
            entity.Property(e => e.IdRol).HasColumnName("Id_rol");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.RolEmpleadoEventos)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rol_Empleado_Evento_Empleados");

            entity.HasOne(d => d.IdEventoNavigation).WithMany(p => p.RolEmpleadoEventos)
                .HasForeignKey(d => d.IdEvento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rol_Empleado_Evento_Eventos");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.RolEmpleadoEventos)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Rol_Empleado_Evento_Roles");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK__Roles__2D95A8946E4BBD77");

            entity.Property(e => e.IdRol).HasColumnName("Id_rol");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.NombreRol)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_rol");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK__Servicio__A8B83B4DCE7F0C78");

            entity.Property(e => e.IdServicio).HasColumnName("Id_servicio");
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion).HasColumnType("text");
            entity.Property(e => e.NombreServicio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Nombre_servicio");
        });

        modelBuilder.Entity<ServicioUtilerium>(entity =>
        {
            entity.HasKey(e => e.IdServicioUtileria).HasName("PK__Servicio__257D5CB3BEFB8C8A");

            entity.ToTable("Servicio_Utileria");

            entity.Property(e => e.IdServicioUtileria).HasColumnName("Id_servicio_utileria");
            entity.Property(e => e.IdServicio).HasColumnName("Id_servicio");
            entity.Property(e => e.IdUtileria).HasColumnName("Id_utileria");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.ServicioUtileria)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Servicio_Utileria_Servicio");

            entity.HasOne(d => d.IdUtileriaNavigation).WithMany(p => p.ServicioUtileria)
                .HasForeignKey(d => d.IdUtileria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Servicio_Utileria_Utileria");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__EF59F762D4E46934");

            entity.HasIndex(e => e.NombreUsuario, "UC_NombreUsuario").IsUnique();

            entity.Property(e => e.IdUsuario).HasColumnName("Id_usuario");
            entity.Property(e => e.Contraseña)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(true);
            entity.Property(e => e.IdCargo).HasColumnName("Id_Cargo");
            entity.Property(e => e.IdEmpleado).HasColumnName("Id_empleado");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_usuario");

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuarios_Cargos");

            entity.HasOne(d => d.IdEmpleadoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuarios_Empleados");
        });

        modelBuilder.Entity<Utilerium>(entity =>
        {
            entity.HasKey(e => e.IdUtileria).HasName("PK__Utileria__0903F31676ABC069");

            entity.Property(e => e.IdUtileria).HasColumnName("Id_utileria");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
