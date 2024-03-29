﻿// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.RTCAudio.UpdateSendingVolumeOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.RTCAudio
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UpdateSendingVolumeOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_LocalUserId;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_RoomName;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_Volume;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UpdateSendingVolumeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UpdateSendingVolumeOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_LocalUserId;
    [FieldOffset(16)]
    public System.IntPtr m_RoomName;
    [FieldOffset(24)]
    public float m_Volume;

    public unsafe ProductUserId LocalUserId
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946009, XrefRangeEnd = 946013, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Epic.OnlineServices.Utf8String RoomName
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946013, XrefRangeEnd = 946017, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe float Volume
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 196207, RefRangeEnd = 196208, XrefRangeStart = 196207, XrefRangeEnd = 196208, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 946025, RefRangeEnd = 946026, XrefRangeStart = 946017, XrefRangeEnd = 946025, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref UpdateSendingVolumeOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UpdateSendingVolumeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946026, XrefRangeEnd = 946042, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<UpdateSendingVolumeOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UpdateSendingVolumeOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 946042, XrefRangeEnd = 946047, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static UpdateSendingVolumeOptionsInternal()
    {
      Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.RTCAudio", nameof (UpdateSendingVolumeOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr);
      UpdateSendingVolumeOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      UpdateSendingVolumeOptionsInternal.NativeFieldInfoPtr_m_LocalUserId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, nameof (m_LocalUserId));
      UpdateSendingVolumeOptionsInternal.NativeFieldInfoPtr_m_RoomName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, nameof (m_RoomName));
      UpdateSendingVolumeOptionsInternal.NativeFieldInfoPtr_m_Volume = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, nameof (m_Volume));
      UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_set_LocalUserId_Public_set_Void_ProductUserId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, 100667504);
      UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_set_RoomName_Public_set_Void_Utf8String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, 100667505);
      UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_set_Volume_Public_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, 100667506);
      UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_UpdateSendingVolumeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, 100667507);
      UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_UpdateSendingVolumeOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, 100667508);
      UpdateSendingVolumeOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, 100667509);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UpdateSendingVolumeOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
