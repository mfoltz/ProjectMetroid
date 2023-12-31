// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.SpellModBlob_UI
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellModBlob_UI
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Values;
    private static readonly System.IntPtr NativeFieldInfoPtr_UIValues;
    private static readonly System.IntPtr NativeFieldInfoPtr_DescriptionKey;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBuiltDescription_Public_LocalizedString_byref_CurveCollection_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0;
    [FieldOffset(0)]
    public BlobArray<SpellModBlobValue> Values;
    [FieldOffset(8)]
    public BlobArray<SpellModBlobValue_UI> UIValues;
    [FieldOffset(16)]
    public LocalizationKey DescriptionKey;

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 798696, RefRangeEnd = 798702, XrefRangeStart = 798686, XrefRangeEnd = 798696, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LocalizedString GetBuiltDescription(
      [In] ref CurveCollection curveCollection,
      float power,
      Nullable_Unboxed<float> minPower = default (Nullable_Unboxed<float>),
      Nullable_Unboxed<float> maxPower = default (Nullable_Unboxed<float>))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) ref curveCollection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &power;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &minPower;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &maxPower;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpellModBlob_UI.NativeMethodInfoPtr_GetBuiltDescription_Public_LocalizedString_byref_CurveCollection_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new LocalizedString(pointer);
    }

    static SpellModBlob_UI()
    {
      Il2CppClassPointerStore<SpellModBlob_UI>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (SpellModBlob_UI));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellModBlob_UI>.NativeClassPtr);
      SpellModBlob_UI.NativeFieldInfoPtr_Values = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlob_UI>.NativeClassPtr, nameof (Values));
      SpellModBlob_UI.NativeFieldInfoPtr_UIValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlob_UI>.NativeClassPtr, nameof (UIValues));
      SpellModBlob_UI.NativeFieldInfoPtr_DescriptionKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellModBlob_UI>.NativeClassPtr, nameof (DescriptionKey));
      SpellModBlob_UI.NativeMethodInfoPtr_GetBuiltDescription_Public_LocalizedString_byref_CurveCollection_Single_Nullable_Unboxed_1_Single_Nullable_Unboxed_1_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellModBlob_UI>.NativeClassPtr, 100670431);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellModBlob_UI>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
