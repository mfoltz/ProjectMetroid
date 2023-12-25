// Decompiled with JetBrains decompiler
// Type: ProjectM.SetLocalizationCommandSystem
// Assembly: ProjectM.ScriptableSystems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 4FC41C5A-90E3-4DE6-83F1-AE360FF7C5FF
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.ScriptableSystems.dll

using Engine.Console;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class SetLocalizationCommandSystem : ConsoleCommandSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SuggestionsEntity;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetLocalizationLanguage_Private_Void_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652967, XrefRangeEnd = 1653003, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateConsoleCommands()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetLocalizationCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe bool Allowed()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetLocalizationCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1653003, XrefRangeEnd = 1653004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetLocalizationLanguage(string language)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(language);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetLocalizationCommandSystem.NativeMethodInfoPtr_SetLocalizationLanguage_Private_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 732837, RefRangeEnd = 732840, XrefRangeStart = 732837, XrefRangeEnd = 732840, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SetLocalizationCommandSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetLocalizationCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), SetLocalizationCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetLocalizationCommandSystem()
    {
      Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.ScriptableSystems.dll", "ProjectM", nameof (SetLocalizationCommandSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr);
      SetLocalizationCommandSystem.NativeFieldInfoPtr_SuggestionsEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr, nameof (SuggestionsEntity));
      SetLocalizationCommandSystem.NativeMethodInfoPtr_OnCreateConsoleCommands_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr, 100664039);
      SetLocalizationCommandSystem.NativeMethodInfoPtr_Allowed_Protected_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr, 100664040);
      SetLocalizationCommandSystem.NativeMethodInfoPtr_SetLocalizationLanguage_Private_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr, 100664041);
      SetLocalizationCommandSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr, 100664042);
      SetLocalizationCommandSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr, 100664043);
    }

    public SetLocalizationCommandSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Entity SuggestionsEntity
    {
      get
      {
        return *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetLocalizationCommandSystem.NativeFieldInfoPtr_SuggestionsEntity));
      }
      [param: In] set
      {
        *(Entity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SetLocalizationCommandSystem.NativeFieldInfoPtr_SuggestionsEntity)) = value;
      }
    }

    [ObfuscatedName("ProjectM.SetLocalizationCommandSystem/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Internal_Void_ArgumentSuggestionCollection_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SetLocalizationCommandSystem.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetLocalizationCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1652949, XrefRangeEnd = 1652967, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnCreateConsoleCommands_b__1_0(ArgumentSuggestionCollection suggestions)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) suggestions);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(SetLocalizationCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Internal_Void_ArgumentSuggestionCollection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c()
      {
        Il2CppClassPointerStore<SetLocalizationCommandSystem.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SetLocalizationCommandSystem>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetLocalizationCommandSystem.__c>.NativeClassPtr);
        SetLocalizationCommandSystem.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLocalizationCommandSystem.__c>.NativeClassPtr, "<>9");
        SetLocalizationCommandSystem.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetLocalizationCommandSystem.__c>.NativeClassPtr, "<>9__1_0");
        SetLocalizationCommandSystem.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocalizationCommandSystem.__c>.NativeClassPtr, 100664045);
        SetLocalizationCommandSystem.__c.NativeMethodInfoPtr__OnCreateConsoleCommands_b__1_0_Internal_Void_ArgumentSuggestionCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetLocalizationCommandSystem.__c>.NativeClassPtr, 100664046);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe SetLocalizationCommandSystem.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetLocalizationCommandSystem.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (SetLocalizationCommandSystem.__c) null : new SetLocalizationCommandSystem.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetLocalizationCommandSystem.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Action<ArgumentSuggestionCollection> __9__1_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(SetLocalizationCommandSystem.__c.NativeFieldInfoPtr___9__1_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action<ArgumentSuggestionCollection>) null : new Il2CppSystem.Action<ArgumentSuggestionCollection>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(SetLocalizationCommandSystem.__c.NativeFieldInfoPtr___9__1_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
