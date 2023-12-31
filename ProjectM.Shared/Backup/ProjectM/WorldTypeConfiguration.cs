// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldTypeConfiguration
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public sealed class WorldTypeConfiguration : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldType;
    private static readonly System.IntPtr NativeFieldInfoPtr_SystemConfig;
    private static readonly System.IntPtr NativeFieldInfoPtr_AllocationConfig;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_WorldType_WorldTypeSystemConfig_WorldTypeAllocationConfig_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 45041, RefRangeEnd = 45044, XrefRangeStart = 45041, XrefRangeEnd = 45044, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldTypeConfiguration(
      WorldType worldType,
      WorldTypeSystemConfig systemConfig,
      WorldTypeAllocationConfig allocationConfig)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemConfig);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) allocationConfig);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeConfiguration.NativeMethodInfoPtr__ctor_Public_Void_WorldType_WorldTypeSystemConfig_WorldTypeAllocationConfig_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldTypeConfiguration()
    {
      Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldTypeConfiguration));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr);
      WorldTypeConfiguration.NativeFieldInfoPtr_WorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr, nameof (WorldType));
      WorldTypeConfiguration.NativeFieldInfoPtr_SystemConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr, nameof (SystemConfig));
      WorldTypeConfiguration.NativeFieldInfoPtr_AllocationConfig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr, nameof (AllocationConfig));
      WorldTypeConfiguration.NativeMethodInfoPtr__ctor_Public_Void_WorldType_WorldTypeSystemConfig_WorldTypeAllocationConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr, 100663798);
    }

    public WorldTypeConfiguration(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public WorldTypeConfiguration()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldTypeConfiguration>.NativeClassPtr, data));
    }

    public unsafe WorldType WorldType
    {
      get
      {
        return *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeConfiguration.NativeFieldInfoPtr_WorldType));
      }
      [param: In] set
      {
        *(WorldType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeConfiguration.NativeFieldInfoPtr_WorldType)) = value;
      }
    }

    public unsafe WorldTypeSystemConfig SystemConfig
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeConfiguration.NativeFieldInfoPtr_SystemConfig));
        return pointer == System.IntPtr.Zero ? (WorldTypeSystemConfig) null : new WorldTypeSystemConfig(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeConfiguration.NativeFieldInfoPtr_SystemConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WorldTypeAllocationConfig AllocationConfig
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeConfiguration.NativeFieldInfoPtr_AllocationConfig));
        return pointer == System.IntPtr.Zero ? (WorldTypeAllocationConfig) null : new WorldTypeAllocationConfig(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeConfiguration.NativeFieldInfoPtr_AllocationConfig), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
