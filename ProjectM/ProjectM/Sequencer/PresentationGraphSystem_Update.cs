// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.PresentationGraphSystem_Update
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Sequencer;
using System;
using Unity.Entities;

#nullable disable
namespace ProjectM.Sequencer
{
  public class PresentationGraphSystem_Update : UpdateGraphSystemBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetPlaybackType_Protected_Virtual_GraphPlaybackType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetEntityQuery_Protected_Virtual_EntityQuery_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 29193, RefRangeEnd = 29196, XrefRangeStart = 29193, XrefRangeEnd = 29196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe GraphPlaybackType GetPlaybackType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PresentationGraphSystem_Update.NativeMethodInfoPtr_GetPlaybackType_Protected_Virtual_GraphPlaybackType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GraphPlaybackType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1106417, XrefRangeEnd = 1106433, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe EntityQuery GetEntityQuery()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PresentationGraphSystem_Update.NativeMethodInfoPtr_GetEntityQuery_Protected_Virtual_EntityQuery_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PresentationGraphSystem_Update()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PresentationGraphSystem_Update>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PresentationGraphSystem_Update.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), PresentationGraphSystem_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PresentationGraphSystem_Update()
    {
      Il2CppClassPointerStore<PresentationGraphSystem_Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (PresentationGraphSystem_Update));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PresentationGraphSystem_Update>.NativeClassPtr);
      PresentationGraphSystem_Update.NativeMethodInfoPtr_GetPlaybackType_Protected_Virtual_GraphPlaybackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentationGraphSystem_Update>.NativeClassPtr, 100687665);
      PresentationGraphSystem_Update.NativeMethodInfoPtr_GetEntityQuery_Protected_Virtual_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentationGraphSystem_Update>.NativeClassPtr, 100687666);
      PresentationGraphSystem_Update.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentationGraphSystem_Update>.NativeClassPtr, 100687667);
      PresentationGraphSystem_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PresentationGraphSystem_Update>.NativeClassPtr, 100687668);
    }

    public PresentationGraphSystem_Update(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
