// Decompiled with JetBrains decompiler
// Type: ProjectM.ArchetypeCreationTracking
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class ArchetypeCreationTracking : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__States;
    private static readonly System.IntPtr NativeMethodInfoPtr_Start_Public_Static_String_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_End_Public_Static_String_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dump_Public_Static_String_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetArchetypeCount_Private_Static_Int32_World_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_DumpInternal_Private_Static_Void_World_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 977173, RefRangeEnd = 977174, XrefRangeStart = 977150, XrefRangeEnd = 977173, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Start(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.NativeMethodInfoPtr_Start_Public_Static_String_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977174, XrefRangeEnd = 977190, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string End(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.NativeMethodInfoPtr_End_Public_Static_String_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977190, XrefRangeEnd = 977202, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string Dump(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.NativeMethodInfoPtr_Dump_Public_Static_String_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 977216, RefRangeEnd = 977218, XrefRangeStart = 977202, XrefRangeEnd = 977216, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe int GetArchetypeCount(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.NativeMethodInfoPtr_GetArchetypeCount_Private_Static_Int32_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 977323, RefRangeEnd = 977325, XrefRangeStart = 977218, XrefRangeEnd = 977323, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void DumpInternal(World world)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) world);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.NativeMethodInfoPtr_DumpInternal_Private_Static_Void_World_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ArchetypeCreationTracking()
    {
      Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ArchetypeCreationTracking));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr);
      ArchetypeCreationTracking.NativeFieldInfoPtr__States = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, nameof (_States));
      ArchetypeCreationTracking.NativeMethodInfoPtr_Start_Public_Static_String_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, 100675522);
      ArchetypeCreationTracking.NativeMethodInfoPtr_End_Public_Static_String_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, 100675523);
      ArchetypeCreationTracking.NativeMethodInfoPtr_Dump_Public_Static_String_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, 100675524);
      ArchetypeCreationTracking.NativeMethodInfoPtr_GetArchetypeCount_Private_Static_Int32_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, 100675525);
      ArchetypeCreationTracking.NativeMethodInfoPtr_DumpInternal_Private_Static_Void_World_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, 100675526);
    }

    public ArchetypeCreationTracking(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Dictionary<World, ArchetypeCreationTracking.State> _States
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ArchetypeCreationTracking.NativeFieldInfoPtr__States, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Dictionary<World, ArchetypeCreationTracking.State>) null : new Dictionary<World, ArchetypeCreationTracking.State>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ArchetypeCreationTracking.NativeFieldInfoPtr__States, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public class State : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ArchetypeCountOnStart;
      private static readonly System.IntPtr NativeFieldInfoPtr_StartTime;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe State()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCreationTracking.State>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.State.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static State()
      {
        Il2CppClassPointerStore<ArchetypeCreationTracking.State>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, nameof (State));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCreationTracking.State>.NativeClassPtr);
        ArchetypeCreationTracking.State.NativeFieldInfoPtr_ArchetypeCountOnStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCreationTracking.State>.NativeClassPtr, nameof (ArchetypeCountOnStart));
        ArchetypeCreationTracking.State.NativeFieldInfoPtr_StartTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCreationTracking.State>.NativeClassPtr, nameof (StartTime));
        ArchetypeCreationTracking.State.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking.State>.NativeClassPtr, 100675528);
      }

      public State(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe int ArchetypeCountOnStart
      {
        get
        {
          return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArchetypeCreationTracking.State.NativeFieldInfoPtr_ArchetypeCountOnStart));
        }
        [param: In] set
        {
          *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArchetypeCreationTracking.State.NativeFieldInfoPtr_ArchetypeCountOnStart)) = value;
        }
      }

      public unsafe float StartTime
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArchetypeCreationTracking.State.NativeFieldInfoPtr_StartTime));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ArchetypeCreationTracking.State.NativeFieldInfoPtr_StartTime)) = value;
        }
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Entry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_TypeIndex;
      private static readonly System.IntPtr NativeFieldInfoPtr_Count;
      private static readonly System.IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0;
      [FieldOffset(0)]
      public int TypeIndex;
      [FieldOffset(4)]
      public int Count;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977149, XrefRangeEnd = 977150, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe int CompareTo(ArchetypeCreationTracking.Entry other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.Entry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Entry()
      {
        Il2CppClassPointerStore<ArchetypeCreationTracking.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, nameof (Entry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCreationTracking.Entry>.NativeClassPtr);
        ArchetypeCreationTracking.Entry.NativeFieldInfoPtr_TypeIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCreationTracking.Entry>.NativeClassPtr, nameof (TypeIndex));
        ArchetypeCreationTracking.Entry.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCreationTracking.Entry>.NativeClassPtr, nameof (Count));
        ArchetypeCreationTracking.Entry.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking.Entry>.NativeClassPtr, 100675529);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ArchetypeCreationTracking.Entry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.ArchetypeCreationTracking/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__7_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__DumpInternal_b__7_0_Internal_Int32_Entry_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArchetypeCreationTracking.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe int _DumpInternal_b__7_0(ArchetypeCreationTracking.Entry e)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &e;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ArchetypeCreationTracking.__c.NativeMethodInfoPtr__DumpInternal_b__7_0_Internal_Int32_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ArchetypeCreationTracking.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ArchetypeCreationTracking>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArchetypeCreationTracking.__c>.NativeClassPtr);
        ArchetypeCreationTracking.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCreationTracking.__c>.NativeClassPtr, "<>9");
        ArchetypeCreationTracking.__c.NativeFieldInfoPtr___9__7_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArchetypeCreationTracking.__c>.NativeClassPtr, "<>9__7_0");
        ArchetypeCreationTracking.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking.__c>.NativeClassPtr, 100675531);
        ArchetypeCreationTracking.__c.NativeMethodInfoPtr__DumpInternal_b__7_0_Internal_Int32_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArchetypeCreationTracking.__c>.NativeClassPtr, 100675532);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ArchetypeCreationTracking.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ArchetypeCreationTracking.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ArchetypeCreationTracking.__c) null : new ArchetypeCreationTracking.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ArchetypeCreationTracking.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ArchetypeCreationTracking.Entry, int> __9__7_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ArchetypeCreationTracking.__c.NativeFieldInfoPtr___9__7_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ArchetypeCreationTracking.Entry, int>) null : new Il2CppSystem.Func<ArchetypeCreationTracking.Entry, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ArchetypeCreationTracking.__c.NativeFieldInfoPtr___9__7_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
