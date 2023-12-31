// Decompiled with JetBrains decompiler
// Type: ProjectM.InputSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class InputSettings : SettingsBase
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultPath;
    private static readonly IntPtr NativeFieldInfoPtr_LocalPath;
    private static readonly IntPtr NativeFieldInfoPtr_AnalogInputMappings;
    private static readonly IntPtr NativeFieldInfoPtr_KeyInputMappings;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 741685, RefRangeEnd = 741688, XrefRangeStart = 741670, XrefRangeEnd = 741685, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InputSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 741688, XrefRangeEnd = 741703, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe InputSettings(string path)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InputSettings>.NativeClassPtr))
    {
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(InputSettings.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static InputSettings()
    {
      Il2CppClassPointerStore<InputSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (InputSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InputSettings>.NativeClassPtr);
      InputSettings.NativeFieldInfoPtr_DefaultPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, nameof (DefaultPath));
      InputSettings.NativeFieldInfoPtr_LocalPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, nameof (LocalPath));
      InputSettings.NativeFieldInfoPtr_AnalogInputMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, nameof (AnalogInputMappings));
      InputSettings.NativeFieldInfoPtr_KeyInputMappings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, nameof (KeyInputMappings));
      InputSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, 100665435);
      InputSettings.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InputSettings>.NativeClassPtr, 100665436);
    }

    public InputSettings(IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string DefaultPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(InputSettings.NativeFieldInfoPtr_DefaultPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InputSettings.NativeFieldInfoPtr_DefaultPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string LocalPath
    {
      get
      {
        IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(InputSettings.NativeFieldInfoPtr_LocalPath, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(InputSettings.NativeFieldInfoPtr_LocalPath, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe List<AnalogInputMapping> AnalogInputMappings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_AnalogInputMappings));
        return pointer == IntPtr.Zero ? (List<AnalogInputMapping>) null : new List<AnalogInputMapping>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_AnalogInputMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<KeyInputMapping> KeyInputMappings
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_KeyInputMappings));
        return pointer == IntPtr.Zero ? (List<KeyInputMapping>) null : new List<KeyInputMapping>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(InputSettings.NativeFieldInfoPtr_KeyInputMappings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
