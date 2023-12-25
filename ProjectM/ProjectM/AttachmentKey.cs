// Decompiled with JetBrains decompiler
// Type: ProjectM.AttachmentKey
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AttachmentKey
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_EquipmentPrefabGUID;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomizationCategory;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsEquipment;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateEquipmentKey_Public_Static_AttachmentKey_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateCustomizationKey_Public_Static_AttachmentKey_CustomizationCategoryEnum_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentKey_AttachmentKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AttachmentKey_AttachmentKey_0;
    [FieldOffset(0)]
    public int CustomizationIndex;
    [FieldOffset(4)]
    public PrefabGUID EquipmentPrefabGUID;
    [FieldOffset(8)]
    public CustomizationCategoryEnum CustomizationCategory;
    [FieldOffset(9)]
    public bool IsEquipment;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 1044904, RefRangeEnd = 1044912, XrefRangeStart = 1044904, XrefRangeEnd = 1044904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AttachmentKey CreateEquipmentKey(PrefabGUID prefabGuid)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &prefabGuid;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachmentKey.NativeMethodInfoPtr_CreateEquipmentKey_Public_Static_AttachmentKey_PrefabGUID_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AttachmentKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 1044912, RefRangeEnd = 1044922, XrefRangeStart = 1044912, XrefRangeEnd = 1044912, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe AttachmentKey CreateCustomizationKey(
      CustomizationCategoryEnum categoryEnum,
      int customizationIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &categoryEnum;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &customizationIndex;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachmentKey.NativeMethodInfoPtr_CreateCustomizationKey_Public_Static_AttachmentKey_CustomizationCategoryEnum_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(AttachmentKey*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044922, XrefRangeEnd = 1044923, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(AttachmentKey other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachmentKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044923, XrefRangeEnd = 1044927, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachmentKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044927, XrefRangeEnd = 1044931, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachmentKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1044931, XrefRangeEnd = 1044935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe string ToString()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(AttachmentKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 1044936, RefRangeEnd = 1044942, XrefRangeStart = 1044935, XrefRangeEnd = 1044936, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(AttachmentKey guid1, AttachmentKey guid2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &guid1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &guid2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachmentKey.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentKey_AttachmentKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1044943, RefRangeEnd = 1044944, XrefRangeStart = 1044942, XrefRangeEnd = 1044943, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(AttachmentKey guid1, AttachmentKey guid2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &guid1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &guid2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AttachmentKey.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AttachmentKey_AttachmentKey_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AttachmentKey()
    {
      Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AttachmentKey));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr);
      AttachmentKey.NativeFieldInfoPtr_CustomizationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, nameof (CustomizationIndex));
      AttachmentKey.NativeFieldInfoPtr_EquipmentPrefabGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, nameof (EquipmentPrefabGUID));
      AttachmentKey.NativeFieldInfoPtr_CustomizationCategory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, nameof (CustomizationCategory));
      AttachmentKey.NativeFieldInfoPtr_IsEquipment = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, nameof (IsEquipment));
      AttachmentKey.NativeMethodInfoPtr_CreateEquipmentKey_Public_Static_AttachmentKey_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, 100681876);
      AttachmentKey.NativeMethodInfoPtr_CreateCustomizationKey_Public_Static_AttachmentKey_CustomizationCategoryEnum_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, 100681877);
      AttachmentKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, 100681878);
      AttachmentKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, 100681879);
      AttachmentKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, 100681880);
      AttachmentKey.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, 100681881);
      AttachmentKey.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentKey_AttachmentKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, 100681882);
      AttachmentKey.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AttachmentKey_AttachmentKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, 100681883);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachmentKey>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
