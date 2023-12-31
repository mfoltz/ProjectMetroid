// Decompiled with JetBrains decompiler
// Type: ProjectM.SaveCleanupData
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SaveCleanupData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NewestDate;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldestDate;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewestToSave;
    private static readonly System.IntPtr NativeFieldInfoPtr_OldestToSave;
    private static readonly System.IntPtr NativeMethodInfoPtr_New_Public_Static_SaveCleanupData_DateTime_DateTime_Int32_Int32_0;
    [FieldOffset(0)]
    public Il2CppSystem.DateTime NewestDate;
    [FieldOffset(8)]
    public Il2CppSystem.DateTime OldestDate;
    [FieldOffset(16)]
    public int NewestToSave;
    [FieldOffset(20)]
    public int OldestToSave;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 736324, RefRangeEnd = 736325, XrefRangeStart = 736324, XrefRangeEnd = 736324, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe SaveCleanupData New(
      Il2CppSystem.DateTime newestDate,
      Il2CppSystem.DateTime oldestDate,
      int newestToSave,
      int oldestToSave)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &newestDate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &oldestDate;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &newestToSave;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &oldestToSave;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SaveCleanupData.NativeMethodInfoPtr_New_Public_Static_SaveCleanupData_DateTime_DateTime_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(SaveCleanupData*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SaveCleanupData()
    {
      Il2CppClassPointerStore<SaveCleanupData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (SaveCleanupData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SaveCleanupData>.NativeClassPtr);
      SaveCleanupData.NativeFieldInfoPtr_NewestDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveCleanupData>.NativeClassPtr, nameof (NewestDate));
      SaveCleanupData.NativeFieldInfoPtr_OldestDate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveCleanupData>.NativeClassPtr, nameof (OldestDate));
      SaveCleanupData.NativeFieldInfoPtr_NewestToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveCleanupData>.NativeClassPtr, nameof (NewestToSave));
      SaveCleanupData.NativeFieldInfoPtr_OldestToSave = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SaveCleanupData>.NativeClassPtr, nameof (OldestToSave));
      SaveCleanupData.NativeMethodInfoPtr_New_Public_Static_SaveCleanupData_DateTime_DateTime_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SaveCleanupData>.NativeClassPtr, 100665003);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SaveCleanupData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
