// Decompiled with JetBrains decompiler
// Type: ProjectM.AutoSaveSmartKeepEntry
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
  public class AutoSaveSmartKeepEntry : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Minutes;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewestToSave;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldestToSave;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 173115, RefRangeEnd = 173132, XrefRangeStart = 173115, XrefRangeEnd = 173132, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AutoSaveSmartKeepEntry(int minutes, int newestToSave, int oldestToSave)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoSaveSmartKeepEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &minutes;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &newestToSave;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &oldestToSave;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AutoSaveSmartKeepEntry.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AutoSaveSmartKeepEntry()
    {
      Il2CppClassPointerStore<AutoSaveSmartKeepEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AutoSaveSmartKeepEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoSaveSmartKeepEntry>.NativeClassPtr);
      AutoSaveSmartKeepEntry.NativeFieldInfoPtr_Minutes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSaveSmartKeepEntry>.NativeClassPtr, nameof (Minutes));
      AutoSaveSmartKeepEntry.NativeFieldInfoPtr_NewestToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSaveSmartKeepEntry>.NativeClassPtr, nameof (NewestToSave));
      AutoSaveSmartKeepEntry.NativeFieldInfoPtr_OldestToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoSaveSmartKeepEntry>.NativeClassPtr, nameof (OldestToSave));
      AutoSaveSmartKeepEntry.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoSaveSmartKeepEntry>.NativeClassPtr, 100666005);
    }

    public AutoSaveSmartKeepEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Minutes
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoSaveSmartKeepEntry.NativeFieldInfoPtr_Minutes));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoSaveSmartKeepEntry.NativeFieldInfoPtr_Minutes)) = value;
      }
    }

    public unsafe int NewestToSave
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoSaveSmartKeepEntry.NativeFieldInfoPtr_NewestToSave));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoSaveSmartKeepEntry.NativeFieldInfoPtr_NewestToSave)) = value;
      }
    }

    public unsafe int OldestToSave
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoSaveSmartKeepEntry.NativeFieldInfoPtr_OldestToSave));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AutoSaveSmartKeepEntry.NativeFieldInfoPtr_OldestToSave)) = value;
      }
    }
  }
}
