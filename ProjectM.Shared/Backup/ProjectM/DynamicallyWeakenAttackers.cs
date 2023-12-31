// Decompiled with JetBrains decompiler
// Type: ProjectM.DynamicallyWeakenAttackers
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
  public struct DynamicallyWeakenAttackers
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Multiplier;
    private static readonly System.IntPtr NativeFieldInfoPtr_MultiplierReductionFactorPerCrowdedness;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPlayers;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_DynamicallyWeakenAttackers_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsEmpty_Public_Boolean_0;
    [FieldOffset(0)]
    public float Multiplier;
    [FieldOffset(4)]
    public float MultiplierReductionFactorPerCrowdedness;
    [FieldOffset(8)]
    public int MaxPlayers;

    public static unsafe DynamicallyWeakenAttackers Empty
    {
      [CallerCount(0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicallyWeakenAttackers.NativeMethodInfoPtr_get_Empty_Public_Static_get_DynamicallyWeakenAttackers_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(DynamicallyWeakenAttackers*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 727161, RefRangeEnd = 727162, XrefRangeStart = 727161, XrefRangeEnd = 727161, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsEmpty()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DynamicallyWeakenAttackers.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DynamicallyWeakenAttackers()
    {
      Il2CppClassPointerStore<DynamicallyWeakenAttackers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DynamicallyWeakenAttackers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DynamicallyWeakenAttackers>.NativeClassPtr);
      DynamicallyWeakenAttackers.NativeFieldInfoPtr_Multiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicallyWeakenAttackers>.NativeClassPtr, nameof (Multiplier));
      DynamicallyWeakenAttackers.NativeFieldInfoPtr_MultiplierReductionFactorPerCrowdedness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicallyWeakenAttackers>.NativeClassPtr, nameof (MultiplierReductionFactorPerCrowdedness));
      DynamicallyWeakenAttackers.NativeFieldInfoPtr_MaxPlayers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DynamicallyWeakenAttackers>.NativeClassPtr, nameof (MaxPlayers));
      DynamicallyWeakenAttackers.NativeMethodInfoPtr_get_Empty_Public_Static_get_DynamicallyWeakenAttackers_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicallyWeakenAttackers>.NativeClassPtr, 100664317);
      DynamicallyWeakenAttackers.NativeMethodInfoPtr_IsEmpty_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DynamicallyWeakenAttackers>.NativeClassPtr, 100664318);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DynamicallyWeakenAttackers>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
