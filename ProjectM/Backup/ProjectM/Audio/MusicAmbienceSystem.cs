// Decompiled with JetBrains decompiler
// Type: ProjectM.Audio.MusicAmbienceSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine.Rendering;

#nullable disable
namespace ProjectM.Audio
{
  public class MusicAmbienceSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__StudioManagerSystem;
    private static readonly IntPtr NativeFieldInfoPtr_MusicInstance;
    private static readonly IntPtr NativeFieldInfoPtr_AmbienceInstance;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnVolumeStackUpdate_Private_Void_VolumeStack_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142210, XrefRangeEnd = 1142245, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MusicAmbienceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142245, XrefRangeEnd = 1142270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnDestroy()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MusicAmbienceSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142270, XrefRangeEnd = 1142316, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnVolumeStackUpdate(VolumeStack volumeStack)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) volumeStack);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicAmbienceSystem.NativeMethodInfoPtr_OnVolumeStackUpdate_Private_Void_VolumeStack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1142316, XrefRangeEnd = 1142323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MusicAmbienceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MusicAmbienceSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MusicAmbienceSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MusicAmbienceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MusicAmbienceSystem()
    {
      Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Audio", nameof (MusicAmbienceSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr);
      MusicAmbienceSystem.NativeFieldInfoPtr__StudioManagerSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, nameof (_StudioManagerSystem));
      MusicAmbienceSystem.NativeFieldInfoPtr_MusicInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, nameof (MusicInstance));
      MusicAmbienceSystem.NativeFieldInfoPtr_AmbienceInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, nameof (AmbienceInstance));
      MusicAmbienceSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, 100690395);
      MusicAmbienceSystem.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, 100690396);
      MusicAmbienceSystem.NativeMethodInfoPtr_OnVolumeStackUpdate_Private_Void_VolumeStack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, 100690397);
      MusicAmbienceSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, 100690398);
      MusicAmbienceSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, 100690399);
      MusicAmbienceSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MusicAmbienceSystem>.NativeClassPtr, 100690400);
    }

    public MusicAmbienceSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe StudioManagerSystem _StudioManagerSystem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSystem.NativeFieldInfoPtr__StudioManagerSystem));
        return pointer == IntPtr.Zero ? (StudioManagerSystem) null : new StudioManagerSystem(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MusicAmbienceSystem.NativeFieldInfoPtr__StudioManagerSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe MusicAmbienceInstance MusicInstance
    {
      get
      {
        IntPtr data = __untypedstackalloc((IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, (uint&) IntPtr.Zero));
        IL2CPP.il2cpp_field_static_get_value(MusicAmbienceSystem.NativeFieldInfoPtr_MusicInstance, (void*) data);
        return new MusicAmbienceInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, data));
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MusicAmbienceSystem.NativeFieldInfoPtr_MusicInstance, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
      }
    }

    public static unsafe MusicAmbienceInstance AmbienceInstance
    {
      get
      {
        IntPtr data = __untypedstackalloc((IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, (uint&) IntPtr.Zero));
        IL2CPP.il2cpp_field_static_get_value(MusicAmbienceSystem.NativeFieldInfoPtr_AmbienceInstance, (void*) data);
        return new MusicAmbienceInstance(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MusicAmbienceInstance>.NativeClassPtr, data));
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(MusicAmbienceSystem.NativeFieldInfoPtr_AmbienceInstance, (void*) IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value)));
      }
    }
  }
}
