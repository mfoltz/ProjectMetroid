// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldSystemConfig_UnitTests
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM
{
  public class WorldSystemConfig_UnitTests : WorldTypeSystemConfig
  {
    private static readonly IntPtr NativeMethodInfoPtr_get_RequireExplicitSpawnInWorldDeclaration_Public_Virtual_get_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public override unsafe bool RequireExplicitSpawnInWorldDeclaration
    {
      [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), WorldSystemConfig_UnitTests.NativeMethodInfoPtr_get_RequireExplicitSpawnInWorldDeclaration_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722326, XrefRangeEnd = 722421, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldSystemConfig_UnitTests()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldSystemConfig_UnitTests>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldSystemConfig_UnitTests.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldSystemConfig_UnitTests()
    {
      Il2CppClassPointerStore<WorldSystemConfig_UnitTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldSystemConfig_UnitTests));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldSystemConfig_UnitTests>.NativeClassPtr);
      WorldSystemConfig_UnitTests.NativeMethodInfoPtr_get_RequireExplicitSpawnInWorldDeclaration_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSystemConfig_UnitTests>.NativeClassPtr, 100663794);
      WorldSystemConfig_UnitTests.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldSystemConfig_UnitTests>.NativeClassPtr, 100663795);
    }

    public WorldSystemConfig_UnitTests(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
