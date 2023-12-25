// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleWorkstationUpdateEvents
// Assembly: ProjectM.CastleBuilding.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DA7B9521-B45B-4FC8-A2B0-77040A5D8FB7
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.CastleBuilding.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class CastleWorkstationUpdateEvents : TileModelUpdateEvents<CastleWorkstation>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200345, XrefRangeEnd = 1200351, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CastleWorkstationUpdateEvents()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CastleWorkstationUpdateEvents>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleWorkstationUpdateEvents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1200351, XrefRangeEnd = 1200354, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CastleWorkstationUpdateEvents.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleWorkstationUpdateEvents()
    {
      Il2CppClassPointerStore<CastleWorkstationUpdateEvents>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.CastleBuilding.Systems.dll", "ProjectM.CastleBuilding", nameof (CastleWorkstationUpdateEvents));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleWorkstationUpdateEvents>.NativeClassPtr);
      CastleWorkstationUpdateEvents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWorkstationUpdateEvents>.NativeClassPtr, 100664329);
      CastleWorkstationUpdateEvents.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleWorkstationUpdateEvents>.NativeClassPtr, 100664330);
    }

    public CastleWorkstationUpdateEvents(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
