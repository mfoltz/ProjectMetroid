// Decompiled with JetBrains decompiler
// Type: Stunlock.Sequencer.DebugGraphNode
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Stunlock.Sequencer
{
  public sealed class DebugGraphNode : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_GraphName;
    private static readonly System.IntPtr NativeFieldInfoPtr_RegisterName;
    private static readonly System.IntPtr NativeFieldInfoPtr_Type;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlackboardRegisterIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_BlackboardRegisterType_Int32_0;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 63150, RefRangeEnd = 63153, XrefRangeStart = 63150, XrefRangeEnd = 63153, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugGraphNode(
      string graphName,
      string registerName,
      BlackboardRegisterType type,
      int blackboardRegisterIndex)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(graphName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(registerName);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &type;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &blackboardRegisterIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugGraphNode.NativeMethodInfoPtr__ctor_Public_Void_String_String_BlackboardRegisterType_Int32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugGraphNode()
    {
      Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Stunlock.Sequencer", nameof (DebugGraphNode));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr);
      DebugGraphNode.NativeFieldInfoPtr_GraphName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr, nameof (GraphName));
      DebugGraphNode.NativeFieldInfoPtr_RegisterName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr, nameof (RegisterName));
      DebugGraphNode.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr, nameof (Type));
      DebugGraphNode.NativeFieldInfoPtr_BlackboardRegisterIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr, nameof (BlackboardRegisterIndex));
      DebugGraphNode.NativeMethodInfoPtr__ctor_Public_Void_String_String_BlackboardRegisterType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr, 100663909);
    }

    public DebugGraphNode(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public DebugGraphNode()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DebugGraphNode>.NativeClassPtr, data));
    }

    public unsafe string GraphName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugGraphNode.NativeFieldInfoPtr_GraphName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugGraphNode.NativeFieldInfoPtr_GraphName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string RegisterName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugGraphNode.NativeFieldInfoPtr_RegisterName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugGraphNode.NativeFieldInfoPtr_RegisterName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe BlackboardRegisterType Type
    {
      get
      {
        return *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugGraphNode.NativeFieldInfoPtr_Type));
      }
      [param: In] set
      {
        *(BlackboardRegisterType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugGraphNode.NativeFieldInfoPtr_Type)) = value;
      }
    }

    public unsafe int BlackboardRegisterIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugGraphNode.NativeFieldInfoPtr_BlackboardRegisterIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugGraphNode.NativeFieldInfoPtr_BlackboardRegisterIndex)) = value;
      }
    }
  }
}
