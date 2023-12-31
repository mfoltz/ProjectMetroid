// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldTypeAllocationConfig
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class WorldTypeAllocationConfig : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WorldConfiguration;
    private static readonly System.IntPtr NativeFieldInfoPtr_SceneSystemConfiguration;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldTypeAllocationConfig()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldTypeAllocationConfig>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldTypeAllocationConfig.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldTypeAllocationConfig()
    {
      Il2CppClassPointerStore<WorldTypeAllocationConfig>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldTypeAllocationConfig));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldTypeAllocationConfig>.NativeClassPtr);
      WorldTypeAllocationConfig.NativeFieldInfoPtr_WorldConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTypeAllocationConfig>.NativeClassPtr, nameof (WorldConfiguration));
      WorldTypeAllocationConfig.NativeFieldInfoPtr_SceneSystemConfiguration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldTypeAllocationConfig>.NativeClassPtr, nameof (SceneSystemConfiguration));
      WorldTypeAllocationConfig.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldTypeAllocationConfig>.NativeClassPtr, 100663708);
    }

    public WorldTypeAllocationConfig(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WorldConfiguration WorldConfiguration
    {
      get
      {
        return *(WorldConfiguration*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeAllocationConfig.NativeFieldInfoPtr_WorldConfiguration));
      }
      [param: In] set
      {
        *(WorldConfiguration*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeAllocationConfig.NativeFieldInfoPtr_WorldConfiguration)) = value;
      }
    }

    public unsafe Nullable_Unboxed<Unity.Scenes.SceneSystemConfiguration> SceneSystemConfiguration
    {
      get
      {
        return *(Nullable_Unboxed<Unity.Scenes.SceneSystemConfiguration>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeAllocationConfig.NativeFieldInfoPtr_SceneSystemConfiguration));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(WorldTypeAllocationConfig.NativeFieldInfoPtr_SceneSystemConfiguration), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<Unity.Scenes.SceneSystemConfiguration>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
