// Decompiled with JetBrains decompiler
// Type: ProjectM.ManagedNameGeneratorData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ManagedNameGeneratorData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NamePrefixes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NamePostfixes;
    private static readonly System.IntPtr NativeFieldInfoPtr_PrebuiltStrings;
    private static readonly System.IntPtr NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object System_ICloneable_Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedNameGeneratorData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ManagedNameGeneratorData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ManagedNameGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ManagedNameGeneratorData()
    {
      Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ManagedNameGeneratorData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr);
      ManagedNameGeneratorData.NativeFieldInfoPtr_NamePrefixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr, nameof (NamePrefixes));
      ManagedNameGeneratorData.NativeFieldInfoPtr_NamePostfixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr, nameof (NamePostfixes));
      ManagedNameGeneratorData.NativeFieldInfoPtr_PrebuiltStrings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr, nameof (PrebuiltStrings));
      ManagedNameGeneratorData.NativeMethodInfoPtr_System_ICloneable_Clone_Private_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr, 100664527);
      ManagedNameGeneratorData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr, 100664528);
    }

    public ManagedNameGeneratorData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<LocalizationKey> NamePrefixes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedNameGeneratorData.NativeFieldInfoPtr_NamePrefixes));
        return pointer == System.IntPtr.Zero ? (List<LocalizationKey>) null : new List<LocalizationKey>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedNameGeneratorData.NativeFieldInfoPtr_NamePrefixes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<LocalizationKey> NamePostfixes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedNameGeneratorData.NativeFieldInfoPtr_NamePostfixes));
        return pointer == System.IntPtr.Zero ? (List<LocalizationKey>) null : new List<LocalizationKey>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedNameGeneratorData.NativeFieldInfoPtr_NamePostfixes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<ManagedNameGeneratorData.NameCombinationKey, string> PrebuiltStrings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ManagedNameGeneratorData.NativeFieldInfoPtr_PrebuiltStrings));
        return pointer == System.IntPtr.Zero ? (Dictionary<ManagedNameGeneratorData.NameCombinationKey, string>) null : new Dictionary<ManagedNameGeneratorData.NameCombinationKey, string>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ManagedNameGeneratorData.NativeFieldInfoPtr_PrebuiltStrings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct NameCombinationKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Postfix;
      private static readonly System.IntPtr NativeFieldInfoPtr_Prefix;
      private static readonly System.IntPtr NativeFieldInfoPtr_PostfixSource;
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefixSource;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NameCombinationKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public byte Postfix;
      [FieldOffset(1)]
      public byte Prefix;
      [FieldOffset(4)]
      public PrefabGUID PostfixSource;
      [FieldOffset(8)]
      public PrefabGUID PrefixSource;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728688, XrefRangeEnd = 728690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(ManagedNameGeneratorData.NameCombinationKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedNameGeneratorData.NameCombinationKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NameCombinationKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728690, XrefRangeEnd = 728695, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedNameGeneratorData.NameCombinationKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 728695, XrefRangeEnd = 728697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ManagedNameGeneratorData.NameCombinationKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static NameCombinationKey()
      {
        Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ManagedNameGeneratorData>.NativeClassPtr, nameof (NameCombinationKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr);
        ManagedNameGeneratorData.NameCombinationKey.NativeFieldInfoPtr_Postfix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr, nameof (Postfix));
        ManagedNameGeneratorData.NameCombinationKey.NativeFieldInfoPtr_Prefix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr, nameof (Prefix));
        ManagedNameGeneratorData.NameCombinationKey.NativeFieldInfoPtr_PostfixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr, nameof (PostfixSource));
        ManagedNameGeneratorData.NameCombinationKey.NativeFieldInfoPtr_PrefixSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr, nameof (PrefixSource));
        ManagedNameGeneratorData.NameCombinationKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_NameCombinationKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr, 100664529);
        ManagedNameGeneratorData.NameCombinationKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr, 100664530);
        ManagedNameGeneratorData.NameCombinationKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr, 100664531);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ManagedNameGeneratorData.NameCombinationKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
