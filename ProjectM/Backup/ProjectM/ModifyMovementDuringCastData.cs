// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyMovementDuringCastData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ModifyMovementDuringCastData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MovementSpeedMultiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_InDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_OutDuration;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_0;
    [FieldOffset(0)]
    public float MovementSpeedMultiplier;
    [FieldOffset(4)]
    public float InDuration;
    [FieldOffset(8)]
    public float Duration;
    [FieldOffset(12)]
    public float OutDuration;

    public unsafe float TotalDuration
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 996182, RefRangeEnd = 996183, XrefRangeStart = 996182, XrefRangeEnd = 996182, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifyMovementDuringCastData.NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(float*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 996187, RefRangeEnd = 996188, XrefRangeStart = 996183, XrefRangeEnd = 996187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Evaluate(float time, float baseValue)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &baseValue;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ModifyMovementDuringCastData.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ModifyMovementDuringCastData()
    {
      Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyMovementDuringCastData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr);
      ModifyMovementDuringCastData.NativeFieldInfoPtr_MovementSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr, nameof (MovementSpeedMultiplier));
      ModifyMovementDuringCastData.NativeFieldInfoPtr_InDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr, nameof (InDuration));
      ModifyMovementDuringCastData.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr, nameof (Duration));
      ModifyMovementDuringCastData.NativeFieldInfoPtr_OutDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr, nameof (OutDuration));
      ModifyMovementDuringCastData.NativeMethodInfoPtr_get_TotalDuration_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr, 100676961);
      ModifyMovementDuringCastData.NativeMethodInfoPtr_Evaluate_Public_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr, 100676962);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyMovementDuringCastData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
