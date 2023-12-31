// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ConstantCommandMountData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ConstantCommandMountData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Acceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Deceleration;
    private static readonly System.IntPtr NativeFieldInfoPtr_TurnRate;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxSpeedReverse;
    private static readonly System.IntPtr NativeFieldInfoPtr_DegallopSpeedThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_DestroyOnCollisionSpeedThreshold;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxAimAngle;
    private static readonly System.IntPtr NativeFieldInfoPtr_TurnRatePerSpeedCurve;
    private static readonly System.IntPtr NativeFieldInfoPtr_FrictionCurve;
    private static readonly System.IntPtr NativeMethodInfoPtr_FromMounter_Public_Static_Void_byref_Mounter_byref_ConstantCommandMountData_0;
    [FieldOffset(0)]
    public float Acceleration;
    [FieldOffset(4)]
    public float Deceleration;
    [FieldOffset(8)]
    public float TurnRate;
    [FieldOffset(12)]
    public float MaxSpeedReverse;
    [FieldOffset(16)]
    public float DegallopSpeedThreshold;
    [FieldOffset(20)]
    public float DestroyOnCollisionSpeedThreshold;
    [FieldOffset(24)]
    public float MaxAimAngle;
    [FieldOffset(28)]
    public CurveReference TurnRatePerSpeedCurve;
    [FieldOffset(36)]
    public CurveReference FrictionCurve;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 785491, RefRangeEnd = 785493, XrefRangeStart = 785489, XrefRangeEnd = 785491, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void FromMounter([In] ref Mounter mounter, out ConstantCommandMountData result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref mounter;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConstantCommandMountData.NativeMethodInfoPtr_FromMounter_Public_Static_Void_byref_Mounter_byref_ConstantCommandMountData_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConstantCommandMountData()
    {
      Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (ConstantCommandMountData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr);
      ConstantCommandMountData.NativeFieldInfoPtr_Acceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (Acceleration));
      ConstantCommandMountData.NativeFieldInfoPtr_Deceleration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (Deceleration));
      ConstantCommandMountData.NativeFieldInfoPtr_TurnRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (TurnRate));
      ConstantCommandMountData.NativeFieldInfoPtr_MaxSpeedReverse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (MaxSpeedReverse));
      ConstantCommandMountData.NativeFieldInfoPtr_DegallopSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (DegallopSpeedThreshold));
      ConstantCommandMountData.NativeFieldInfoPtr_DestroyOnCollisionSpeedThreshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (DestroyOnCollisionSpeedThreshold));
      ConstantCommandMountData.NativeFieldInfoPtr_MaxAimAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (MaxAimAngle));
      ConstantCommandMountData.NativeFieldInfoPtr_TurnRatePerSpeedCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (TurnRatePerSpeedCurve));
      ConstantCommandMountData.NativeFieldInfoPtr_FrictionCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, nameof (FrictionCurve));
      ConstantCommandMountData.NativeMethodInfoPtr_FromMounter_Public_Static_Void_byref_Mounter_byref_ConstantCommandMountData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, 100669228);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConstantCommandMountData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
