// Decompiled with JetBrains decompiler
// Type: ProjectM.Behaviours.PatrolApproachPosition
// Assembly: ProjectM.Behaviours, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0B013578-4768-467C-9297-D6D62C4210E8
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Behaviours.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Behaviours
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PatrolApproachPosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PositionRegister;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsStationary;
    private static readonly System.IntPtr NativeFieldInfoPtr_SeekedDistance;
    private static readonly System.IntPtr NativeFieldInfoPtr_MIN_SPEED_FACTOR;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SPEED_FACTOR;
    private static readonly System.IntPtr NativeFieldInfoPtr_STAND_STILL_DISTANCE_MIN;
    private static readonly System.IntPtr NativeFieldInfoPtr_STAND_STILL_DISTANCE_MAX;
    private static readonly System.IntPtr NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0;
    [FieldOffset(0)]
    public SharedField<float3> PositionRegister;
    [FieldOffset(4)]
    public PrivateField<bool> IsStationary;
    [FieldOffset(8)]
    public float SeekedDistance;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344063, XrefRangeEnd = 1344096, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe BehaviourTreeResult Tick(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolApproachPosition.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344096, XrefRangeEnd = 1344097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Abort(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolApproachPosition.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1344097, XrefRangeEnd = 1344098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BehaviourTreeResult Exit(
      BehaviourTreeResult result,
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PatrolApproachPosition.NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(BehaviourTreeResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1344104, RefRangeEnd = 1344106, XrefRangeStart = 1344098, XrefRangeEnd = 1344104, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Cleanup(
      ref BehaviourTreeExpansionContext context,
      ref BehaviourTreeJobData jobData)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref context;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref jobData;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PatrolApproachPosition.NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PatrolApproachPosition()
    {
      Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Behaviours.dll", "ProjectM.Behaviours", nameof (PatrolApproachPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr);
      PatrolApproachPosition.NativeFieldInfoPtr_PositionRegister = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, nameof (PositionRegister));
      PatrolApproachPosition.NativeFieldInfoPtr_IsStationary = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, nameof (IsStationary));
      PatrolApproachPosition.NativeFieldInfoPtr_SeekedDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, nameof (SeekedDistance));
      PatrolApproachPosition.NativeFieldInfoPtr_MIN_SPEED_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, nameof (MIN_SPEED_FACTOR));
      PatrolApproachPosition.NativeFieldInfoPtr_MAX_SPEED_FACTOR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, nameof (MAX_SPEED_FACTOR));
      PatrolApproachPosition.NativeFieldInfoPtr_STAND_STILL_DISTANCE_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, nameof (STAND_STILL_DISTANCE_MIN));
      PatrolApproachPosition.NativeFieldInfoPtr_STAND_STILL_DISTANCE_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, nameof (STAND_STILL_DISTANCE_MAX));
      PatrolApproachPosition.NativeMethodInfoPtr_Tick_Public_Virtual_Final_New_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, 100665406);
      PatrolApproachPosition.NativeMethodInfoPtr_Abort_Public_Virtual_Final_New_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, 100665407);
      PatrolApproachPosition.NativeMethodInfoPtr_Exit_Private_BehaviourTreeResult_BehaviourTreeResult_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, 100665408);
      PatrolApproachPosition.NativeMethodInfoPtr_Cleanup_Private_Void_byref_BehaviourTreeExpansionContext_byref_BehaviourTreeJobData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, 100665409);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PatrolApproachPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe float MIN_SPEED_FACTOR
    {
      get
      {
        float minSpeedFactor;
        IL2CPP.il2cpp_field_static_get_value(PatrolApproachPosition.NativeFieldInfoPtr_MIN_SPEED_FACTOR, (void*) &minSpeedFactor);
        return minSpeedFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PatrolApproachPosition.NativeFieldInfoPtr_MIN_SPEED_FACTOR, (void*) &value);
      }
    }

    public static unsafe float MAX_SPEED_FACTOR
    {
      get
      {
        float maxSpeedFactor;
        IL2CPP.il2cpp_field_static_get_value(PatrolApproachPosition.NativeFieldInfoPtr_MAX_SPEED_FACTOR, (void*) &maxSpeedFactor);
        return maxSpeedFactor;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PatrolApproachPosition.NativeFieldInfoPtr_MAX_SPEED_FACTOR, (void*) &value);
      }
    }

    public static unsafe float STAND_STILL_DISTANCE_MIN
    {
      get
      {
        float stillDistanceMin;
        IL2CPP.il2cpp_field_static_get_value(PatrolApproachPosition.NativeFieldInfoPtr_STAND_STILL_DISTANCE_MIN, (void*) &stillDistanceMin);
        return stillDistanceMin;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PatrolApproachPosition.NativeFieldInfoPtr_STAND_STILL_DISTANCE_MIN, (void*) &value);
      }
    }

    public static unsafe float STAND_STILL_DISTANCE_MAX
    {
      get
      {
        float stillDistanceMax;
        IL2CPP.il2cpp_field_static_get_value(PatrolApproachPosition.NativeFieldInfoPtr_STAND_STILL_DISTANCE_MAX, (void*) &stillDistanceMax);
        return stillDistanceMax;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(PatrolApproachPosition.NativeFieldInfoPtr_STAND_STILL_DISTANCE_MAX, (void*) &value);
      }
    }
  }
}
