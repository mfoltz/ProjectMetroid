// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModBlobValue_UI
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModBlobValue_UI
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisplayFormat;
    private static readonly System.IntPtr NativeFieldInfoPtr_DisplayDecimals;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_byref_SpellModBlobValue_byref_CurveCollection_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_Single_float2_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRangeKeyValue_Private_LocalizedKeyValue_Single_Single_Single_0;
    [FieldOffset(0)]
    public FixedString64 Name;
    [FieldOffset(64)]
    public SpellModBlobValue_UI.ValueNumericFormat DisplayFormat;
    [FieldOffset(68)]
    public int DisplayDecimals;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798619, RefRangeEnd = 798620, XrefRangeStart = 798609, XrefRangeEnd = 798619, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedKeyValue GetLocalizedKeyValue(
      [In] ref SpellModBlobValue spellModValue,
      [In] ref CurveCollection curveCollection,
      float power,
      Nullable_Unboxed<float> minPower = default (Nullable_Unboxed<float>),
      Nullable_Unboxed<float> maxPower = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) ref spellModValue;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &power;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &minPower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &maxPower;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellModBlobValue_UI.NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_byref_SpellModBlobValue_byref_CurveCollection_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedKeyValue(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 798641, RefRangeEnd = 798643, XrefRangeStart = 798620, XrefRangeEnd = 798641, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedKeyValue GetLocalizedKeyValue(float value, float2 range = default (float2))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &range;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellModBlobValue_UI.NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_Single_float2_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedKeyValue(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 798685, RefRangeEnd = 798686, XrefRangeStart = 798643, XrefRangeEnd = 798685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedKeyValue GetRangeKeyValue(float value, float min, float max)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellModBlobValue_UI.NativeMethodInfoPtr_GetRangeKeyValue_Private_LocalizedKeyValue_Single_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedKeyValue(pointer);
    }

    static SpellModBlobValue_UI()
    {
      Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModBlobValue_UI));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr);
      SpellModBlobValue_UI.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr, nameof (Name));
      SpellModBlobValue_UI.NativeFieldInfoPtr_DisplayFormat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr, nameof (DisplayFormat));
      SpellModBlobValue_UI.NativeFieldInfoPtr_DisplayDecimals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr, nameof (DisplayDecimals));
      SpellModBlobValue_UI.NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_byref_SpellModBlobValue_byref_CurveCollection_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr, 100670428);
      SpellModBlobValue_UI.NativeMethodInfoPtr_GetLocalizedKeyValue_Public_LocalizedKeyValue_Single_float2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr, 100670429);
      SpellModBlobValue_UI.NativeMethodInfoPtr_GetRangeKeyValue_Private_LocalizedKeyValue_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr, 100670430);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModBlobValue_UI>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public enum ValueNumericFormat
    {
      Default,
      Percent,
    }
  }
}
