// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.AttributeDataValueExt
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices.Sessions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

#nullable disable
namespace ProjectM.EOS
{
  public static class AttributeDataValueExt : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsNumericValue_Public_Static_Boolean_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryNumericalGreaterThan_Public_Static_Boolean_AttributeDataValue_AttributeDataValue_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryNumericalLessThan_Public_Static_Boolean_AttributeDataValue_AttributeDataValue_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAdvance_Public_Static_Boolean_byref_AttributeDataValue_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAdvance_Private_Static_Boolean_byref_Double_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryAdvance_Private_Static_Boolean_byref_Single_Boolean_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124023, RefRangeEnd = 1124024, XrefRangeStart = 1124023, XrefRangeEnd = 1124023, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsNumericValue(this AttributeDataValue value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueExt.NativeMethodInfoPtr_IsNumericValue_Public_Static_Boolean_AttributeDataValue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124046, RefRangeEnd = 1124047, XrefRangeStart = 1124024, XrefRangeEnd = 1124046, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryNumericalGreaterThan(
      this AttributeDataValue lhs,
      AttributeDataValue rhs,
      out bool result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) lhs));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) rhs));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueExt.NativeMethodInfoPtr_TryNumericalGreaterThan_Public_Static_Boolean_AttributeDataValue_AttributeDataValue_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124069, RefRangeEnd = 1124070, XrefRangeStart = 1124047, XrefRangeEnd = 1124069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryNumericalLessThan(
      this AttributeDataValue lhs,
      AttributeDataValue rhs,
      out bool result)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) lhs));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) rhs));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueExt.NativeMethodInfoPtr_TryNumericalLessThan_Public_Static_Boolean_AttributeDataValue_AttributeDataValue_byref_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1124112, RefRangeEnd = 1124113, XrefRangeStart = 1124070, XrefRangeEnd = 1124112, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryAdvance(ref this AttributeDataValue value, bool positive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positive;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueExt.NativeMethodInfoPtr_TryAdvance_Public_Static_Boolean_byref_AttributeDataValue_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124113, XrefRangeEnd = 1124121, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryAdvance(ref double value, bool positive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positive;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueExt.NativeMethodInfoPtr_TryAdvance_Private_Static_Boolean_byref_Double_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1124121, XrefRangeEnd = 1124125, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryAdvance(ref float value, bool positive)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref value;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &positive;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttributeDataValueExt.NativeMethodInfoPtr_TryAdvance_Private_Static_Boolean_byref_Single_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AttributeDataValueExt()
    {
      Il2CppClassPointerStore<AttributeDataValueExt>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (AttributeDataValueExt));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeDataValueExt>.NativeClassPtr);
      AttributeDataValueExt.NativeMethodInfoPtr_IsNumericValue_Public_Static_Boolean_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueExt>.NativeClassPtr, 100689184);
      AttributeDataValueExt.NativeMethodInfoPtr_TryNumericalGreaterThan_Public_Static_Boolean_AttributeDataValue_AttributeDataValue_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueExt>.NativeClassPtr, 100689185);
      AttributeDataValueExt.NativeMethodInfoPtr_TryNumericalLessThan_Public_Static_Boolean_AttributeDataValue_AttributeDataValue_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueExt>.NativeClassPtr, 100689186);
      AttributeDataValueExt.NativeMethodInfoPtr_TryAdvance_Public_Static_Boolean_byref_AttributeDataValue_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueExt>.NativeClassPtr, 100689187);
      AttributeDataValueExt.NativeMethodInfoPtr_TryAdvance_Private_Static_Boolean_byref_Double_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueExt>.NativeClassPtr, 100689188);
      AttributeDataValueExt.NativeMethodInfoPtr_TryAdvance_Private_Static_Boolean_byref_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeDataValueExt>.NativeClassPtr, 100689189);
    }

    public AttributeDataValueExt(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
