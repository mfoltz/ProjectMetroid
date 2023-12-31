// Decompiled with JetBrains decompiler
// Type: ProjectM.HeartLimits
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
  public class HeartLimits : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Level1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level3;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level4;
    private static readonly System.IntPtr NativeFieldInfoPtr_Level5;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 758995, RefRangeEnd = 758996, XrefRangeStart = 758965, XrefRangeEnd = 758995, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe Il2CppSystem.Object Clone()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HeartLimits.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HeartLimits()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HeartLimits.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HeartLimits()
    {
      Il2CppClassPointerStore<HeartLimits>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (HeartLimits));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr);
      HeartLimits.NativeFieldInfoPtr_Level1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr, nameof (Level1));
      HeartLimits.NativeFieldInfoPtr_Level2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr, nameof (Level2));
      HeartLimits.NativeFieldInfoPtr_Level3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr, nameof (Level3));
      HeartLimits.NativeFieldInfoPtr_Level4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr, nameof (Level4));
      HeartLimits.NativeFieldInfoPtr_Level5 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr, nameof (Level5));
      HeartLimits.NativeMethodInfoPtr_Clone_Public_Virtual_Final_New_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr, 100666985);
      HeartLimits.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HeartLimits>.NativeClassPtr, 100666986);
    }

    public HeartLimits(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe HeartLevelLimit Level1
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level1));
        return pointer == System.IntPtr.Zero ? (HeartLevelLimit) null : new HeartLevelLimit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HeartLevelLimit Level2
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level2));
        return pointer == System.IntPtr.Zero ? (HeartLevelLimit) null : new HeartLevelLimit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level2), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HeartLevelLimit Level3
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level3));
        return pointer == System.IntPtr.Zero ? (HeartLevelLimit) null : new HeartLevelLimit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level3), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HeartLevelLimit Level4
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level4));
        return pointer == System.IntPtr.Zero ? (HeartLevelLimit) null : new HeartLevelLimit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level4), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe HeartLevelLimit Level5
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level5));
        return pointer == System.IntPtr.Zero ? (HeartLevelLimit) null : new HeartLevelLimit(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(HeartLimits.NativeFieldInfoPtr_Level5), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
