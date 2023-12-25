// Decompiled with JetBrains decompiler
// Type: ProjectM.MutePlayerSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class MutePlayerSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__MuteChatList;
    private static readonly IntPtr NativeFieldInfoPtr__MuteVoiceList;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_MuteVoice_Public_Void_UInt64_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_MuteChat_Public_Void_UInt64_Boolean_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsVoiceMuted_Public_Boolean_UInt64_0;
    private static readonly IntPtr NativeMethodInfoPtr_IsChatMuted_Public_Boolean_UInt64_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MutePlayerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047523, XrefRangeEnd = 1047524, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MutePlayerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1047528, RefRangeEnd = 1047530, XrefRangeStart = 1047524, XrefRangeEnd = 1047528, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MuteVoice(ulong platformId, bool mute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &platformId;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &mute;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MutePlayerSystem.NativeMethodInfoPtr_MuteVoice_Public_Void_UInt64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1047534, RefRangeEnd = 1047536, XrefRangeStart = 1047530, XrefRangeEnd = 1047534, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void MuteChat(ulong platformId, bool mute)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[2];
      numPtr[0] = (IntPtr) &platformId;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &mute;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MutePlayerSystem.NativeMethodInfoPtr_MuteChat_Public_Void_UInt64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1047538, RefRangeEnd = 1047540, XrefRangeStart = 1047536, XrefRangeEnd = 1047538, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsVoiceMuted(ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &platformId;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MutePlayerSystem.NativeMethodInfoPtr_IsVoiceMuted_Public_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1047542, RefRangeEnd = 1047544, XrefRangeStart = 1047540, XrefRangeEnd = 1047542, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsChatMuted(ulong platformId)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = (IntPtr) &platformId;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(MutePlayerSystem.NativeMethodInfoPtr_IsChatMuted_Public_Boolean_UInt64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1047544, XrefRangeEnd = 1047558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MutePlayerSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MutePlayerSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), MutePlayerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MutePlayerSystem()
    {
      Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (MutePlayerSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr);
      MutePlayerSystem.NativeFieldInfoPtr__MuteChatList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, nameof (_MuteChatList));
      MutePlayerSystem.NativeFieldInfoPtr__MuteVoiceList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, nameof (_MuteVoiceList));
      MutePlayerSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, 100682118);
      MutePlayerSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, 100682119);
      MutePlayerSystem.NativeMethodInfoPtr_MuteVoice_Public_Void_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, 100682120);
      MutePlayerSystem.NativeMethodInfoPtr_MuteChat_Public_Void_UInt64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, 100682121);
      MutePlayerSystem.NativeMethodInfoPtr_IsVoiceMuted_Public_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, 100682122);
      MutePlayerSystem.NativeMethodInfoPtr_IsChatMuted_Public_Boolean_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, 100682123);
      MutePlayerSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, 100682124);
      MutePlayerSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MutePlayerSystem>.NativeClassPtr, 100682125);
    }

    public MutePlayerSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe FileUserList _MuteChatList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MutePlayerSystem.NativeFieldInfoPtr__MuteChatList));
        return pointer == IntPtr.Zero ? (FileUserList) null : new FileUserList(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MutePlayerSystem.NativeFieldInfoPtr__MuteChatList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FileUserList _MuteVoiceList
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MutePlayerSystem.NativeFieldInfoPtr__MuteVoiceList));
        return pointer == IntPtr.Zero ? (FileUserList) null : new FileUserList(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MutePlayerSystem.NativeFieldInfoPtr__MuteVoiceList), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
