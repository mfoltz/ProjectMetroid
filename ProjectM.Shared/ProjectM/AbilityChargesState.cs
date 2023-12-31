// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityChargesState
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AbilityChargesState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCharges;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentChargeTime_Public_Single_0;
    [FieldOffset(0)]
    public float ChargeTime;
    [FieldOffset(4)]
    public int CurrentCharges;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 724691, RefRangeEnd = 724693, XrefRangeStart = 724690, XrefRangeEnd = 724691, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetCurrentChargeTime()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityChargesState.NativeMethodInfoPtr_GetCurrentChargeTime_Public_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AbilityChargesState()
    {
      Il2CppClassPointerStore<AbilityChargesState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityChargesState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityChargesState>.NativeClassPtr);
      AbilityChargesState.NativeFieldInfoPtr_ChargeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargesState>.NativeClassPtr, nameof (ChargeTime));
      AbilityChargesState.NativeFieldInfoPtr_CurrentCharges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityChargesState>.NativeClassPtr, nameof (CurrentCharges));
      AbilityChargesState.NativeMethodInfoPtr_GetCurrentChargeTime_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityChargesState>.NativeClassPtr, 100664103);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityChargesState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
