// Decompiled with JetBrains decompiler
// Type: ProjectM.CooldownUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class CooldownUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetCooldown_Public_Static_Single_byref_AbilityCooldownData_byref_AbilityCooldownState_Double_Single_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 732842, RefRangeEnd = 732844, XrefRangeStart = 732840, XrefRangeEnd = 732842, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe float ResetCooldown(
      [In] ref AbilityCooldownData cooldownData,
      ref AbilityCooldownState cooldownState,
      double serverTime,
      float modifier = 1f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref cooldownData;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref cooldownState;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &serverTime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &modifier;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CooldownUtility.NativeMethodInfoPtr_ResetCooldown_Public_Static_Single_byref_AbilityCooldownData_byref_AbilityCooldownState_Double_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static CooldownUtility()
    {
      Il2CppClassPointerStore<CooldownUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CooldownUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CooldownUtility>.NativeClassPtr);
      CooldownUtility.NativeMethodInfoPtr_ResetCooldown_Public_Static_Single_byref_AbilityCooldownData_byref_AbilityCooldownState_Double_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CooldownUtility>.NativeClassPtr, 100664763);
    }

    public CooldownUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
