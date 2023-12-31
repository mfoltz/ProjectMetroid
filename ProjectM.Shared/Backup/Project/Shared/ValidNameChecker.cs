// Decompiled with JetBrains decompiler
// Type: Project.Shared.ValidNameChecker
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Text.RegularExpressions;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace Project.Shared
{
  public static class ValidNameChecker : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__LatinDefault;
    private static readonly System.IntPtr NativeFieldInfoPtr__HangulSyllables;
    private static readonly System.IntPtr NativeFieldInfoPtr__LatinExtended;
    private static readonly System.IntPtr NativeFieldInfoPtr__InvalidCharacterRegexPattern;
    private static readonly System.IntPtr NativeFieldInfoPtr__ArabicCharactersRegexPattern;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SPACES_IN_PLAYER_NAMES;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_SPACES_IN_NAMES;
    private static readonly System.IntPtr NativeFieldInfoPtr_MAX_CHARACTER_NAME_LENGTH;
    private static readonly System.IntPtr NativeFieldInfoPtr_LINE_BREAK_PATTERN;
    private static readonly System.IntPtr NativeFieldInfoPtr__CachedResults;
    private static readonly System.IntPtr NativeFieldInfoPtr__FixedCachedResults;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValidName_Public_Static_ValidNameResult_FixedString64_byref_String_ValidNameMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetValidName_Public_Static_ValidNameResult_byref_String_ValidNameMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FixArabic_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetValidNameResult_Public_Static_ValidNameResult_String_ValidNameMode_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RemoveInvalidCharacters_Public_Static_String_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryStripRegexPattern_Public_Static_Boolean_byref_String_String_RegexOptions_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 717296, RefRangeEnd = 717297, XrefRangeStart = 717279, XrefRangeEnd = 717296, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ValidNameResult TryGetValidName(
      FixedString64 name,
      out string nameResult,
      ValidNameMode nameMode = ValidNameMode.Names)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      numPtr1[0] = (System.IntPtr) &name;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &nameMode;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.NativeMethodInfoPtr_TryGetValidName_Public_Static_ValidNameResult_FixedString64_byref_String_ValidNameMode_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      nameResult = IL2CPP.Il2CppStringToManaged(zero);
      return *(ValidNameResult*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(6)]
    [CachedScanResults(RefRangeStart = 717327, RefRangeEnd = 717333, XrefRangeStart = 717297, XrefRangeEnd = 717327, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ValidNameResult TryGetValidName(ref string name, ValidNameMode nameMode = ValidNameMode.Names)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr* numPtr3 = &il2Cpp;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nameMode;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.NativeMethodInfoPtr_TryGetValidName_Public_Static_ValidNameResult_byref_String_ValidNameMode_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      name = IL2CPP.Il2CppStringToManaged(il2Cpp);
      return *(ValidNameResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(16)]
    [CachedScanResults(RefRangeStart = 717342, RefRangeEnd = 717358, XrefRangeStart = 717333, XrefRangeEnd = 717342, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string FixArabic(string text)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(text);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.NativeMethodInfoPtr_FixArabic_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(21)]
    [CachedScanResults(RefRangeStart = 717384, RefRangeEnd = 717405, XrefRangeStart = 717358, XrefRangeEnd = 717384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ValidNameResult GetValidNameResult(string name, ValidNameMode nameMode = ValidNameMode.Names)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &nameMode;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.NativeMethodInfoPtr_GetValidNameResult_Public_Static_ValidNameResult_String_ValidNameMode_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ValidNameResult*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717405, XrefRangeEnd = 717415, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string RemoveInvalidCharacters(string name)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(name);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.NativeMethodInfoPtr_RemoveInvalidCharacters_Public_Static_String_String_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(23)]
    [CachedScanResults(RefRangeStart = 717426, RefRangeEnd = 717449, XrefRangeStart = 717415, XrefRangeEnd = 717426, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool TryStripRegexPattern(
      ref string input,
      string regexPattern,
      RegexOptions options = RegexOptions.Multiline)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[3];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr il2Cpp = IL2CPP.ManagedStringToIl2Cpp(input);
      System.IntPtr* numPtr3 = &il2Cpp;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(regexPattern);
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &options;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.NativeMethodInfoPtr_TryStripRegexPattern_Public_Static_Boolean_byref_String_String_RegexOptions_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      input = IL2CPP.Il2CppStringToManaged(il2Cpp);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ValidNameChecker()
    {
      Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "Project.Shared", nameof (ValidNameChecker));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr);
      ValidNameChecker.NativeFieldInfoPtr__LatinDefault = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (_LatinDefault));
      ValidNameChecker.NativeFieldInfoPtr__HangulSyllables = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (_HangulSyllables));
      ValidNameChecker.NativeFieldInfoPtr__LatinExtended = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (_LatinExtended));
      ValidNameChecker.NativeFieldInfoPtr__InvalidCharacterRegexPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (_InvalidCharacterRegexPattern));
      ValidNameChecker.NativeFieldInfoPtr__ArabicCharactersRegexPattern = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (_ArabicCharactersRegexPattern));
      ValidNameChecker.NativeFieldInfoPtr_MAX_SPACES_IN_PLAYER_NAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (MAX_SPACES_IN_PLAYER_NAMES));
      ValidNameChecker.NativeFieldInfoPtr_MAX_SPACES_IN_NAMES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (MAX_SPACES_IN_NAMES));
      ValidNameChecker.NativeFieldInfoPtr_MAX_CHARACTER_NAME_LENGTH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (MAX_CHARACTER_NAME_LENGTH));
      ValidNameChecker.NativeFieldInfoPtr_LINE_BREAK_PATTERN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (LINE_BREAK_PATTERN));
      ValidNameChecker.NativeFieldInfoPtr__CachedResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (_CachedResults));
      ValidNameChecker.NativeFieldInfoPtr__FixedCachedResults = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (_FixedCachedResults));
      ValidNameChecker.NativeMethodInfoPtr_TryGetValidName_Public_Static_ValidNameResult_FixedString64_byref_String_ValidNameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, 100663525);
      ValidNameChecker.NativeMethodInfoPtr_TryGetValidName_Public_Static_ValidNameResult_byref_String_ValidNameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, 100663526);
      ValidNameChecker.NativeMethodInfoPtr_FixArabic_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, 100663527);
      ValidNameChecker.NativeMethodInfoPtr_GetValidNameResult_Public_Static_ValidNameResult_String_ValidNameMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, 100663528);
      ValidNameChecker.NativeMethodInfoPtr_RemoveInvalidCharacters_Public_Static_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, 100663529);
      ValidNameChecker.NativeMethodInfoPtr_TryStripRegexPattern_Public_Static_Boolean_byref_String_String_RegexOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, 100663530);
    }

    public ValidNameChecker(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string _LatinDefault
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr__LatinDefault, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr__LatinDefault, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string _HangulSyllables
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr__HangulSyllables, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr__HangulSyllables, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string _LatinExtended
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr__LatinExtended, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr__LatinExtended, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string _InvalidCharacterRegexPattern
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr__InvalidCharacterRegexPattern, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr__InvalidCharacterRegexPattern, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string _ArabicCharactersRegexPattern
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr__ArabicCharactersRegexPattern, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr__ArabicCharactersRegexPattern, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe int MAX_SPACES_IN_PLAYER_NAMES
    {
      get
      {
        int spacesInPlayerNames;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr_MAX_SPACES_IN_PLAYER_NAMES, (void*) &spacesInPlayerNames);
        return spacesInPlayerNames;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr_MAX_SPACES_IN_PLAYER_NAMES, (void*) &value);
      }
    }

    public static unsafe int MAX_SPACES_IN_NAMES
    {
      get
      {
        int maxSpacesInNames;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr_MAX_SPACES_IN_NAMES, (void*) &maxSpacesInNames);
        return maxSpacesInNames;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr_MAX_SPACES_IN_NAMES, (void*) &value);
      }
    }

    public static unsafe int MAX_CHARACTER_NAME_LENGTH
    {
      get
      {
        int characterNameLength;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr_MAX_CHARACTER_NAME_LENGTH, (void*) &characterNameLength);
        return characterNameLength;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr_MAX_CHARACTER_NAME_LENGTH, (void*) &value);
      }
    }

    public static unsafe string LINE_BREAK_PATTERN
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr_LINE_BREAK_PATTERN, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr_LINE_BREAK_PATTERN, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Dictionary<ValidNameChecker.CachedNameKey, ValidNameChecker.CachedNameResult> _CachedResults
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr__CachedResults, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<ValidNameChecker.CachedNameKey, ValidNameChecker.CachedNameResult>) null : new Dictionary<ValidNameChecker.CachedNameKey, ValidNameChecker.CachedNameResult>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr__CachedResults, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe Dictionary<ValidNameChecker.CachedNameFixedKey, ValidNameChecker.CachedNameResult> _FixedCachedResults
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ValidNameChecker.NativeFieldInfoPtr__FixedCachedResults, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<ValidNameChecker.CachedNameFixedKey, ValidNameChecker.CachedNameResult>) null : new Dictionary<ValidNameChecker.CachedNameFixedKey, ValidNameChecker.CachedNameResult>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ValidNameChecker.NativeFieldInfoPtr__FixedCachedResults, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class CachedNameKey : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Mode;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedNameKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717268, XrefRangeEnd = 717269, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(ValidNameChecker.CachedNameKey other)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other));
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.CachedNameKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedNameKey_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717269, XrefRangeEnd = 717273, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe bool Equals(Il2CppSystem.Object obj)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.CachedNameKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.CachedNameKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static CachedNameKey()
      {
        Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (CachedNameKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr);
        ValidNameChecker.CachedNameKey.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr, nameof (Name));
        ValidNameChecker.CachedNameKey.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr, nameof (Mode));
        ValidNameChecker.CachedNameKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedNameKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr, 100663532);
        ValidNameChecker.CachedNameKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr, 100663533);
        ValidNameChecker.CachedNameKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr, 100663534);
      }

      public CachedNameKey(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public CachedNameKey()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidNameChecker.CachedNameKey>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidNameChecker.CachedNameKey.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ValidNameChecker.CachedNameKey.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe ValidNameMode Mode
      {
        get
        {
          return *(ValidNameMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidNameChecker.CachedNameKey.NativeFieldInfoPtr_Mode));
        }
        [param: In] set
        {
          *(ValidNameMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidNameChecker.CachedNameKey.NativeFieldInfoPtr_Mode)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CachedNameFixedKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Mode;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedNameFixedKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public FixedString64 Name;
      [FieldOffset(64)]
      public ValidNameMode Mode;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717273, XrefRangeEnd = 717274, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(ValidNameChecker.CachedNameFixedKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.CachedNameFixedKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedNameFixedKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717274, XrefRangeEnd = 717278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.CachedNameFixedKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 717278, XrefRangeEnd = 717279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ValidNameChecker.CachedNameFixedKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static CachedNameFixedKey()
      {
        Il2CppClassPointerStore<ValidNameChecker.CachedNameFixedKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (CachedNameFixedKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidNameChecker.CachedNameFixedKey>.NativeClassPtr);
        ValidNameChecker.CachedNameFixedKey.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker.CachedNameFixedKey>.NativeClassPtr, nameof (Name));
        ValidNameChecker.CachedNameFixedKey.NativeFieldInfoPtr_Mode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker.CachedNameFixedKey>.NativeClassPtr, nameof (Mode));
        ValidNameChecker.CachedNameFixedKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_CachedNameFixedKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker.CachedNameFixedKey>.NativeClassPtr, 100663535);
        ValidNameChecker.CachedNameFixedKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker.CachedNameFixedKey>.NativeClassPtr, 100663536);
        ValidNameChecker.CachedNameFixedKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ValidNameChecker.CachedNameFixedKey>.NativeClassPtr, 100663537);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidNameChecker.CachedNameFixedKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class CachedNameResult : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Name;
      private static readonly System.IntPtr NativeFieldInfoPtr_Result;

      static CachedNameResult()
      {
        Il2CppClassPointerStore<ValidNameChecker.CachedNameResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ValidNameChecker>.NativeClassPtr, nameof (CachedNameResult));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ValidNameChecker.CachedNameResult>.NativeClassPtr);
        ValidNameChecker.CachedNameResult.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker.CachedNameResult>.NativeClassPtr, nameof (Name));
        ValidNameChecker.CachedNameResult.NativeFieldInfoPtr_Result = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ValidNameChecker.CachedNameResult>.NativeClassPtr, nameof (Result));
      }

      public CachedNameResult(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public CachedNameResult()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ValidNameChecker.CachedNameResult>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ValidNameChecker.CachedNameResult>.NativeClassPtr, data));
      }

      public unsafe string Name
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidNameChecker.CachedNameResult.NativeFieldInfoPtr_Name)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ValidNameChecker.CachedNameResult.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe ValidNameResult Result
      {
        get
        {
          return *(ValidNameResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidNameChecker.CachedNameResult.NativeFieldInfoPtr_Result));
        }
        [param: In] set
        {
          *(ValidNameResult*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ValidNameChecker.CachedNameResult.NativeFieldInfoPtr_Result)) = value;
        }
      }
    }
  }
}
