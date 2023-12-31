// Decompiled with JetBrains decompiler
// Type: ProjectM.SaveFileData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class SaveFileData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionIdFileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_StartDateFileName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Path;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    private static readonly System.IntPtr NativeFieldInfoPtr_SessionId;
    private static readonly System.IntPtr NativeFieldInfoPtr_Time;
    private static readonly System.IntPtr NativeFieldInfoPtr_HostSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_GameSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSharedSave;
    private static readonly System.IntPtr NativeFieldInfoPtr_Corrupt;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SaveFileData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SaveFileData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SaveFileData()
    {
      Il2CppClassPointerStore<SaveFileData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SaveFileData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr);
      SaveFileData.NativeFieldInfoPtr_SessionIdFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (SessionIdFileName));
      SaveFileData.NativeFieldInfoPtr_StartDateFileName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (StartDateFileName));
      SaveFileData.NativeFieldInfoPtr_Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (Path));
      SaveFileData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (Name));
      SaveFileData.NativeFieldInfoPtr_SessionId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (SessionId));
      SaveFileData.NativeFieldInfoPtr_Time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (Time));
      SaveFileData.NativeFieldInfoPtr_HostSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (HostSettings));
      SaveFileData.NativeFieldInfoPtr_GameSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (GameSettings));
      SaveFileData.NativeFieldInfoPtr_IsSharedSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (IsSharedSave));
      SaveFileData.NativeFieldInfoPtr_Corrupt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, nameof (Corrupt));
      SaveFileData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveFileData>.NativeClassPtr, 100664967);
    }

    public SaveFileData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe string SessionIdFileName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SaveFileData.NativeFieldInfoPtr_SessionIdFileName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SaveFileData.NativeFieldInfoPtr_SessionIdFileName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string StartDateFileName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(SaveFileData.NativeFieldInfoPtr_StartDateFileName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(SaveFileData.NativeFieldInfoPtr_StartDateFileName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Path
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_Path)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_Path), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Name
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_Name)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string SessionId
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_SessionId)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_SessionId), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe Il2CppSystem.DateTime Time
    {
      get
      {
        return *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_Time));
      }
      [param: In] set
      {
        *(Il2CppSystem.DateTime*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_Time)) = value;
      }
    }

    public unsafe ServerHostSettings HostSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_HostSettings));
        return pointer == System.IntPtr.Zero ? (ServerHostSettings) null : new ServerHostSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_HostSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe ServerGameSettings GameSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_GameSettings));
        return pointer == System.IntPtr.Zero ? (ServerGameSettings) null : new ServerGameSettings(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_GameSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool IsSharedSave
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_IsSharedSave));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_IsSharedSave)) = value;
      }
    }

    public unsafe bool Corrupt
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_Corrupt));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SaveFileData.NativeFieldInfoPtr_Corrupt)) = value;
      }
    }
  }
}
