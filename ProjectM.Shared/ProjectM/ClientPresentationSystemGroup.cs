// Decompiled with JetBrains decompiler
// Type: ProjectM.ClientPresentationSystemGroup
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Diagnostics;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ClientPresentationSystemGroup : PresentationSystemGroup
  {
    private static readonly IntPtr NativeFieldInfoPtr__Timer;
    private static readonly IntPtr NativeFieldInfoPtr_LastFrameTimeSeconds;
    private static readonly IntPtr NativeFieldInfoPtr__NextUpdate;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720814, XrefRangeEnd = 720822, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClientPresentationSystemGroup()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClientPresentationSystemGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 720822, XrefRangeEnd = 720830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientPresentationSystemGroup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ClientPresentationSystemGroup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClientPresentationSystemGroup()
    {
      Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ClientPresentationSystemGroup));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr);
      ClientPresentationSystemGroup.NativeFieldInfoPtr__Timer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr, nameof (_Timer));
      ClientPresentationSystemGroup.NativeFieldInfoPtr_LastFrameTimeSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr, nameof (LastFrameTimeSeconds));
      ClientPresentationSystemGroup.NativeFieldInfoPtr__NextUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr, nameof (_NextUpdate));
      ClientPresentationSystemGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr, 100663696);
      ClientPresentationSystemGroup.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr, 100663697);
      ClientPresentationSystemGroup.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClientPresentationSystemGroup>.NativeClassPtr, 100663698);
    }

    public ClientPresentationSystemGroup(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Stopwatch _Timer
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientPresentationSystemGroup.NativeFieldInfoPtr__Timer));
        return pointer == IntPtr.Zero ? (Stopwatch) null : new Stopwatch(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClientPresentationSystemGroup.NativeFieldInfoPtr__Timer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe double LastFrameTimeSeconds
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientPresentationSystemGroup.NativeFieldInfoPtr_LastFrameTimeSeconds));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientPresentationSystemGroup.NativeFieldInfoPtr_LastFrameTimeSeconds)) = value;
      }
    }

    public unsafe double _NextUpdate
    {
      get
      {
        return *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientPresentationSystemGroup.NativeFieldInfoPtr__NextUpdate));
      }
      [param: In] set
      {
        *(double*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClientPresentationSystemGroup.NativeFieldInfoPtr__NextUpdate)) = value;
      }
    }
  }
}
