// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleStatModifiers
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Text;
using Stunlock.Network;
using System;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleStatModifiers
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TickPeriod;
    private static readonly System.IntPtr NativeFieldInfoPtr_SafetyBoxLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_VerminNestLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_TombLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrisonCellLimit;
    private static readonly System.IntPtr NativeFieldInfoPtr_HeartLimits;
    private static readonly System.IntPtr NativeFieldInfoPtr_CastleLimits;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_CastleStatModifiers_byref_NetBufferOut_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Static_CastleStatModifiers_byref_NetBufferIn_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0;
    [FieldOffset(0)]
    public float TickPeriod;
    [FieldOffset(4)]
    public byte SafetyBoxLimit;
    [FieldOffset(5)]
    public byte VerminNestLimit;
    [FieldOffset(6)]
    public byte TombLimit;
    [FieldOffset(7)]
    public byte PrisonCellLimit;
    [FieldOffset(8)]
    public FixedList64<HeartLevelLimit.StructData> HeartLimits;
    [FieldOffset(72)]
    public FixedList64<UserCastleLimit.StructData> CastleLimits;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 759029, RefRangeEnd = 759030, XrefRangeStart = 758996, XrefRangeEnd = 759029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Serialize(
      [In] ref CastleStatModifiers settings,
      ref NetBufferOut netBuffer)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref settings;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref netBuffer;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleStatModifiers.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_CastleStatModifiers_byref_NetBufferOut_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 759073, RefRangeEnd = 759074, XrefRangeStart = 759030, XrefRangeEnd = 759073, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe CastleStatModifiers Deserialize(ref NetBufferIn netBuffer, int version)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &version;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleStatModifiers.NativeMethodInfoPtr_Deserialize_Public_Static_CastleStatModifiers_byref_NetBufferIn_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(CastleStatModifiers*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 759074, XrefRangeEnd = 759128, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AppendToString(StringBuilder stringBuilder, string prefix)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) stringBuilder);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(prefix);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CastleStatModifiers.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CastleStatModifiers()
    {
      Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CastleStatModifiers));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr);
      CastleStatModifiers.NativeFieldInfoPtr_TickPeriod = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, nameof (TickPeriod));
      CastleStatModifiers.NativeFieldInfoPtr_SafetyBoxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, nameof (SafetyBoxLimit));
      CastleStatModifiers.NativeFieldInfoPtr_VerminNestLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, nameof (VerminNestLimit));
      CastleStatModifiers.NativeFieldInfoPtr_TombLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, nameof (TombLimit));
      CastleStatModifiers.NativeFieldInfoPtr_PrisonCellLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, nameof (PrisonCellLimit));
      CastleStatModifiers.NativeFieldInfoPtr_HeartLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, nameof (HeartLimits));
      CastleStatModifiers.NativeFieldInfoPtr_CastleLimits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, nameof (CastleLimits));
      CastleStatModifiers.NativeMethodInfoPtr_Serialize_Public_Static_Void_byref_CastleStatModifiers_byref_NetBufferOut_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, 100666987);
      CastleStatModifiers.NativeMethodInfoPtr_Deserialize_Public_Static_CastleStatModifiers_byref_NetBufferIn_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, 100666988);
      CastleStatModifiers.NativeMethodInfoPtr_AppendToString_Public_Void_StringBuilder_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, 100666989);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleStatModifiers>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
