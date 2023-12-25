// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.SetupGraphSystem_Update
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
  public class SetupGraphSystem_Update : UpdateGraphSystemBase
  {
    private static readonly IntPtr NativeMethodInfoPtr_GetPlaybackType_Protected_Virtual_GraphPlaybackType_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetEntityQuery_Protected_Virtual_EntityQuery_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 31081, RefRangeEnd = 31102, XrefRangeStart = 31081, XrefRangeEnd = 31102, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe GraphPlaybackType GetPlaybackType()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupGraphSystem_Update.NativeMethodInfoPtr_GetPlaybackType_Protected_Virtual_GraphPlaybackType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(GraphPlaybackType*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105971, XrefRangeEnd = 1105990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe EntityQuery GetEntityQuery()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupGraphSystem_Update.NativeMethodInfoPtr_GetEntityQuery_Protected_Virtual_EntityQuery_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetupGraphSystem_Update()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetupGraphSystem_Update>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupGraphSystem_Update.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1105990, XrefRangeEnd = 1105991, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetupGraphSystem_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetupGraphSystem_Update()
    {
      Il2CppClassPointerStore<SetupGraphSystem_Update>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (SetupGraphSystem_Update));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupGraphSystem_Update>.NativeClassPtr);
      SetupGraphSystem_Update.NativeMethodInfoPtr_GetPlaybackType_Protected_Virtual_GraphPlaybackType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupGraphSystem_Update>.NativeClassPtr, 100687619);
      SetupGraphSystem_Update.NativeMethodInfoPtr_GetEntityQuery_Protected_Virtual_EntityQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupGraphSystem_Update>.NativeClassPtr, 100687620);
      SetupGraphSystem_Update.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupGraphSystem_Update>.NativeClassPtr, 100687621);
      SetupGraphSystem_Update.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupGraphSystem_Update>.NativeClassPtr, 100687622);
    }

    public SetupGraphSystem_Update(IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
