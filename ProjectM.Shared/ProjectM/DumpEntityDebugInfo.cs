// Decompiled with JetBrains decompiler
// Type: ProjectM.DumpEntityDebugInfo
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DumpEntityDebugInfo
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Ref;
    private static readonly System.IntPtr NativeFieldInfoPtr__EventStack;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Internal_Void_UnsafeList_1_EventData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PushEntityToDump_Public_Static_Void_WorldType_Entity_DumpEntityTarget_ComponentTypes_EntityDumpUniquenessId_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ResetFrame_Internal_Void_byref_Int64_byref_Int64_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasEvents_Internal_Boolean_0;
    [FieldOffset(0)]
    public DebugEventStack<DumpEntityDebugInfo.EventData> _EventStack;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733254, XrefRangeEnd = 733257, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DumpEntityDebugInfo(UnsafeList<DumpEntityDebugInfo.EventData> data)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DumpEntityDebugInfo.NativeMethodInfoPtr__ctor_Internal_Void_UnsafeList_1_EventData_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 733285, RefRangeEnd = 733287, XrefRangeStart = 733257, XrefRangeEnd = 733285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PushEntityToDump(
      WorldType worldType,
      Entity entity,
      DumpEntityTarget target,
      ComponentTypes componentsToDump = default (ComponentTypes),
      EntityDumpUniquenessId uniquenessId = default (EntityDumpUniquenessId),
      bool crashAfterDump = false)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &worldType;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &target;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &componentsToDump;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &uniquenessId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &crashAfterDump;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DumpEntityDebugInfo.NativeMethodInfoPtr_PushEntityToDump_Public_Static_Void_WorldType_Entity_DumpEntityTarget_ComponentTypes_EntityDumpUniquenessId_Boolean_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733287, XrefRangeEnd = 733295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ResetFrame(out long unconsumedEventCount, out long requestedEventsForFrame)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref unconsumedEventCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref requestedEventsForFrame;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DumpEntityDebugInfo.NativeMethodInfoPtr_ResetFrame_Internal_Void_byref_Int64_byref_Int64_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 733295, XrefRangeEnd = 733298, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasEvents()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DumpEntityDebugInfo.NativeMethodInfoPtr_HasEvents_Internal_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DumpEntityDebugInfo()
    {
      Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DumpEntityDebugInfo));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr);
      DumpEntityDebugInfo.NativeFieldInfoPtr_Ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr, nameof (Ref));
      DumpEntityDebugInfo.NativeFieldInfoPtr__EventStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr, nameof (_EventStack));
      DumpEntityDebugInfo.NativeMethodInfoPtr__ctor_Internal_Void_UnsafeList_1_EventData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr, 100664798);
      DumpEntityDebugInfo.NativeMethodInfoPtr_PushEntityToDump_Public_Static_Void_WorldType_Entity_DumpEntityTarget_ComponentTypes_EntityDumpUniquenessId_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr, 100664799);
      DumpEntityDebugInfo.NativeMethodInfoPtr_ResetFrame_Internal_Void_byref_Int64_byref_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr, 100664800);
      DumpEntityDebugInfo.NativeMethodInfoPtr_HasEvents_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr, 100664801);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe SharedStatic<DumpEntityDebugInfo> Ref
    {
      get
      {
        SharedStatic<DumpEntityDebugInfo> sharedStatic;
        IL2CPP.il2cpp_field_static_get_value(DumpEntityDebugInfo.NativeFieldInfoPtr_Ref, (void*) &sharedStatic);
        return sharedStatic;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(DumpEntityDebugInfo.NativeFieldInfoPtr_Ref, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct EventData
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_WorldType;
      private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
      private static readonly System.IntPtr NativeFieldInfoPtr_ComponentsToDump;
      private static readonly System.IntPtr NativeFieldInfoPtr_DumpLevel;
      private static readonly System.IntPtr NativeFieldInfoPtr_UniquenessId;
      private static readonly System.IntPtr NativeFieldInfoPtr_CrashAfterDump;
      [FieldOffset(0)]
      public WorldType WorldType;
      [FieldOffset(4)]
      public Entity Entity;
      [FieldOffset(12)]
      public ComponentTypes ComponentsToDump;
      [FieldOffset(84)]
      public DumpEntityLevel DumpLevel;
      [FieldOffset(88)]
      public EntityDumpUniquenessId UniquenessId;
      [FieldOffset(96)]
      public bool CrashAfterDump;

      static EventData()
      {
        Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DumpEntityDebugInfo>.NativeClassPtr, nameof (EventData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr);
        DumpEntityDebugInfo.EventData.NativeFieldInfoPtr_WorldType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr, nameof (WorldType));
        DumpEntityDebugInfo.EventData.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr, nameof (Entity));
        DumpEntityDebugInfo.EventData.NativeFieldInfoPtr_ComponentsToDump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr, nameof (ComponentsToDump));
        DumpEntityDebugInfo.EventData.NativeFieldInfoPtr_DumpLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr, nameof (DumpLevel));
        DumpEntityDebugInfo.EventData.NativeFieldInfoPtr_UniquenessId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr, nameof (UniquenessId));
        DumpEntityDebugInfo.EventData.NativeFieldInfoPtr_CrashAfterDump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr, nameof (CrashAfterDump));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DumpEntityDebugInfo.EventData>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
