// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldAllocationConfig_DefaultWorld
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
  public class WorldAllocationConfig_DefaultWorld : WorldTypeAllocationConfig
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 722277, XrefRangeEnd = 722284, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe WorldAllocationConfig_DefaultWorld()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldAllocationConfig_DefaultWorld>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldAllocationConfig_DefaultWorld.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldAllocationConfig_DefaultWorld()
    {
      Il2CppClassPointerStore<WorldAllocationConfig_DefaultWorld>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (WorldAllocationConfig_DefaultWorld));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldAllocationConfig_DefaultWorld>.NativeClassPtr);
      WorldAllocationConfig_DefaultWorld.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldAllocationConfig_DefaultWorld>.NativeClassPtr, 100663785);
    }

    public WorldAllocationConfig_DefaultWorld(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
