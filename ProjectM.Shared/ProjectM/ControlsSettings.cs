// Decompiled with JetBrains decompiler
// Type: ProjectM.ControlsSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public class ControlsSettings : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CameraSensitivity;
    private static readonly System.IntPtr NativeFieldInfoPtr_InvertedCamera;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 748690, RefRangeEnd = 748691, XrefRangeStart = 748689, XrefRangeEnd = 748690, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ControlsSettings()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ControlsSettings>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ControlsSettings.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ControlsSettings()
    {
      Il2CppClassPointerStore<ControlsSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ControlsSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ControlsSettings>.NativeClassPtr);
      ControlsSettings.NativeFieldInfoPtr_CameraSensitivity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsSettings>.NativeClassPtr, nameof (CameraSensitivity));
      ControlsSettings.NativeFieldInfoPtr_InvertedCamera = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ControlsSettings>.NativeClassPtr, nameof (InvertedCamera));
      ControlsSettings.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ControlsSettings>.NativeClassPtr, 100665919);
    }

    public ControlsSettings(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float CameraSensitivity
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsSettings.NativeFieldInfoPtr_CameraSensitivity));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsSettings.NativeFieldInfoPtr_CameraSensitivity)) = value;
      }
    }

    public unsafe bool InvertedCamera
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsSettings.NativeFieldInfoPtr_InvertedCamera));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ControlsSettings.NativeFieldInfoPtr_InvertedCamera)) = value;
      }
    }
  }
}
