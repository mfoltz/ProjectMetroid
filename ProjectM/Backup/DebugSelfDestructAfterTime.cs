// Decompiled with JetBrains decompiler
// Type: DebugSelfDestructAfterTime
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class DebugSelfDestructAfterTime : MonoBehaviour
{
  private static readonly IntPtr NativeFieldInfoPtr_ElapsedTime;
  private static readonly IntPtr NativeFieldInfoPtr_DestroyAfterSeconds;
  private static readonly IntPtr NativeFieldInfoPtr_HasStartedCountdown;
  private static readonly IntPtr NativeMethodInfoPtr_StartCountdown_Public_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  public unsafe void StartCountdown(float destroyAfterSeconds)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &destroyAfterSeconds;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugSelfDestructAfterTime.NativeMethodInfoPtr_StartCountdown_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916375, XrefRangeEnd = 916381, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugSelfDestructAfterTime.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe DebugSelfDestructAfterTime()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(DebugSelfDestructAfterTime.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static DebugSelfDestructAfterTime()
  {
    Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (DebugSelfDestructAfterTime));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr);
    DebugSelfDestructAfterTime.NativeFieldInfoPtr_ElapsedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr, nameof (ElapsedTime));
    DebugSelfDestructAfterTime.NativeFieldInfoPtr_DestroyAfterSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr, nameof (DestroyAfterSeconds));
    DebugSelfDestructAfterTime.NativeFieldInfoPtr_HasStartedCountdown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr, nameof (HasStartedCountdown));
    DebugSelfDestructAfterTime.NativeMethodInfoPtr_StartCountdown_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr, 100663644);
    DebugSelfDestructAfterTime.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr, 100663645);
    DebugSelfDestructAfterTime.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugSelfDestructAfterTime>.NativeClassPtr, 100663646);
  }

  public DebugSelfDestructAfterTime(IntPtr pointer)
    : base(pointer)
  {
  }

  public unsafe float ElapsedTime
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSelfDestructAfterTime.NativeFieldInfoPtr_ElapsedTime));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSelfDestructAfterTime.NativeFieldInfoPtr_ElapsedTime)) = value;
    }
  }

  public unsafe float DestroyAfterSeconds
  {
    get
    {
      return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSelfDestructAfterTime.NativeFieldInfoPtr_DestroyAfterSeconds));
    }
    [param: In] set
    {
      *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSelfDestructAfterTime.NativeFieldInfoPtr_DestroyAfterSeconds)) = value;
    }
  }

  public unsafe bool HasStartedCountdown
  {
    get
    {
      return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSelfDestructAfterTime.NativeFieldInfoPtr_HasStartedCountdown));
    }
    [param: In] set
    {
      *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugSelfDestructAfterTime.NativeFieldInfoPtr_HasStartedCountdown)) = value;
    }
  }
}
