// Decompiled with JetBrains decompiler
// Type: ProjectM.TryCastResultData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TryCastResultData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Ability;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbilityGroup;
    private static readonly System.IntPtr NativeFieldInfoPtr_Result;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomKey;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_TryCastResultData_TryCastResult_LocalizationKey_0;
    [FieldOffset(0)]
    public Entity Ability;
    [FieldOffset(8)]
    public Entity AbilityGroup;
    [FieldOffset(16)]
    public TryCastResult Result;
    [FieldOffset(20)]
    public LocalizationKey CustomKey;

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 995396, RefRangeEnd = 995401, XrefRangeStart = 995396, XrefRangeEnd = 995396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TryCastResultData Set(TryCastResult result, LocalizationKey key = default (LocalizationKey))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &result;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &key;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TryCastResultData.NativeMethodInfoPtr_Set_Public_TryCastResultData_TryCastResult_LocalizationKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TryCastResultData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static TryCastResultData()
    {
      Il2CppClassPointerStore<TryCastResultData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TryCastResultData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TryCastResultData>.NativeClassPtr);
      TryCastResultData.NativeFieldInfoPtr_Ability = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCastResultData>.NativeClassPtr, nameof (Ability));
      TryCastResultData.NativeFieldInfoPtr_AbilityGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCastResultData>.NativeClassPtr, nameof (AbilityGroup));
      TryCastResultData.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCastResultData>.NativeClassPtr, nameof (Result));
      TryCastResultData.NativeFieldInfoPtr_CustomKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TryCastResultData>.NativeClassPtr, nameof (CustomKey));
      TryCastResultData.NativeMethodInfoPtr_Set_Public_TryCastResultData_TryCastResult_LocalizationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TryCastResultData>.NativeClassPtr, 100676884);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TryCastResultData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
