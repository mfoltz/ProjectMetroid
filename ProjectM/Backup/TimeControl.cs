// Decompiled with JetBrains decompiler
// Type: TimeControl
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using Unity.Entities;
using UnityEngine;

#nullable disable
public class TimeControl : MonoBehaviour
{
  private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_IncreaseSpeed_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_DecreaseSpeed_Public_Static_Void_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetTimeScale_Public_Static_Void_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr_SetTimeScale_Internal_Static_Void_World_Single_0;
  private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(10560)]
  [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TimeControl.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916381, XrefRangeEnd = 916390, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void IncreaseSpeed()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TimeControl.NativeMethodInfoPtr_IncreaseSpeed_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 916390, XrefRangeEnd = 916397, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void DecreaseSpeed()
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TimeControl.NativeMethodInfoPtr_DecreaseSpeed_Public_Static_Void_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(8)]
  [CachedScanResults(RefRangeStart = 916452, RefRangeEnd = 916460, XrefRangeStart = 916397, XrefRangeEnd = 916452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTimeScale(float newTimeScale)
  {
    IntPtr* numPtr = stackalloc IntPtr[1];
    numPtr[0] = (IntPtr) &newTimeScale;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TimeControl.NativeMethodInfoPtr_SetTimeScale_Public_Static_Void_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(2)]
  [CachedScanResults(RefRangeStart = 916489, RefRangeEnd = 916491, XrefRangeStart = 916460, XrefRangeEnd = 916489, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public static unsafe void SetTimeScale(World world, float timeScale)
  {
    IntPtr* numPtr = stackalloc IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
    *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &timeScale;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TimeControl.NativeMethodInfoPtr_SetTimeScale_Internal_Static_Void_World_Single_0, IntPtr.Zero, (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(520)]
  [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe TimeControl()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TimeControl>.NativeClassPtr))
  {
    IntPtr* numPtr = (IntPtr*) null;
    IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(TimeControl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static TimeControl()
  {
    Il2CppClassPointerStore<TimeControl>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (TimeControl));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TimeControl>.NativeClassPtr);
    TimeControl.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControl>.NativeClassPtr, 100663648);
    TimeControl.NativeMethodInfoPtr_IncreaseSpeed_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControl>.NativeClassPtr, 100663649);
    TimeControl.NativeMethodInfoPtr_DecreaseSpeed_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControl>.NativeClassPtr, 100663650);
    TimeControl.NativeMethodInfoPtr_SetTimeScale_Public_Static_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControl>.NativeClassPtr, 100663651);
    TimeControl.NativeMethodInfoPtr_SetTimeScale_Internal_Static_Void_World_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControl>.NativeClassPtr, 100663652);
    TimeControl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TimeControl>.NativeClassPtr, 100663653);
  }

  public TimeControl(IntPtr pointer)
    : base(pointer)
  {
  }
}
