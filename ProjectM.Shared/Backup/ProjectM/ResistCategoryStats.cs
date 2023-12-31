// Decompiled with JetBrains decompiler
// Type: ProjectM.ResistCategoryStats
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct ResistCategoryStats
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistVsUndeads;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistVsHumans;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistVsDemons;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistVsMechanical;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistVsBeasts;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResistVsPlayerVampires;
    private static readonly System.IntPtr NativeMethodInfoPtr_Default_Public_Static_ResistCategoryStats_0;
    [FieldOffset(0)]
    public ModifiableFloat ResistVsUndeads;
    [FieldOffset(8)]
    public ModifiableFloat ResistVsHumans;
    [FieldOffset(16)]
    public ModifiableFloat ResistVsDemons;
    [FieldOffset(24)]
    public ModifiableFloat ResistVsMechanical;
    [FieldOffset(32)]
    public ModifiableFloat ResistVsBeasts;
    [FieldOffset(40)]
    public ModifiableFloat ResistVsPlayerVampires;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 762898, XrefRangeEnd = 762904, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ResistCategoryStats Default()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ResistCategoryStats.NativeMethodInfoPtr_Default_Public_Static_ResistCategoryStats_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ResistCategoryStats*) IL2CPP.il2cpp_object_unbox(num);
    }

    static ResistCategoryStats()
    {
      Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ResistCategoryStats));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr);
      ResistCategoryStats.NativeFieldInfoPtr_ResistVsUndeads = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr, nameof (ResistVsUndeads));
      ResistCategoryStats.NativeFieldInfoPtr_ResistVsHumans = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr, nameof (ResistVsHumans));
      ResistCategoryStats.NativeFieldInfoPtr_ResistVsDemons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr, nameof (ResistVsDemons));
      ResistCategoryStats.NativeFieldInfoPtr_ResistVsMechanical = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr, nameof (ResistVsMechanical));
      ResistCategoryStats.NativeFieldInfoPtr_ResistVsBeasts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr, nameof (ResistVsBeasts));
      ResistCategoryStats.NativeFieldInfoPtr_ResistVsPlayerVampires = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr, nameof (ResistVsPlayerVampires));
      ResistCategoryStats.NativeMethodInfoPtr_Default_Public_Static_ResistCategoryStats_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr, 100667403);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ResistCategoryStats>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
