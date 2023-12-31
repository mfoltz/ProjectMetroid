// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityCooldownState
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
  public struct AbilityCooldownState
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CooldownEndTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentCooldown;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetCurrentCooldown_Public_Single_Double_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetCooldown_Public_Void_Single_Double_0;
    [FieldOffset(0)]
    public double CooldownEndTime;
    [FieldOffset(8)]
    public float CurrentCooldown;

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 726494, RefRangeEnd = 726510, XrefRangeStart = 726490, XrefRangeEnd = 726494, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetCurrentCooldown(double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AbilityCooldownState.NativeMethodInfoPtr_GetCurrentCooldown_Public_Single_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(11)]
    [CachedScanResults(RefRangeStart = 726510, RefRangeEnd = 726521, XrefRangeStart = 726510, XrefRangeEnd = 726510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetCooldown(float cooldown, double serverTime)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &cooldown;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityCooldownState.NativeMethodInfoPtr_SetCooldown_Public_Void_Single_Double_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityCooldownState()
    {
      Il2CppClassPointerStore<AbilityCooldownState>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityCooldownState));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityCooldownState>.NativeClassPtr);
      AbilityCooldownState.NativeFieldInfoPtr_CooldownEndTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCooldownState>.NativeClassPtr, nameof (CooldownEndTime));
      AbilityCooldownState.NativeFieldInfoPtr_CurrentCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityCooldownState>.NativeClassPtr, nameof (CurrentCooldown));
      AbilityCooldownState.NativeMethodInfoPtr_GetCurrentCooldown_Public_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCooldownState>.NativeClassPtr, 100664210);
      AbilityCooldownState.NativeMethodInfoPtr_SetCooldown_Public_Void_Single_Double_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityCooldownState>.NativeClassPtr, 100664211);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityCooldownState>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
