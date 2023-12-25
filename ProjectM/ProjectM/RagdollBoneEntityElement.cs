// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollBoneEntityElement
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct RagdollBoneEntityElement
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Value;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_RagdollBoneEntityElement_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_RagdollBoneEntityElement_Entity_0;
    [FieldOffset(0)]
    public Entity Value;

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator Entity(RagdollBoneEntityElement e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollBoneEntityElement.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_RagdollBoneEntityElement_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(Entity*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(4981)]
    [CachedScanResults(RefRangeStart = 10610, RefRangeEnd = 15591, XrefRangeStart = 10610, XrefRangeEnd = 15591, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe implicit operator RagdollBoneEntityElement(Entity e)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &e;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(RagdollBoneEntityElement.NativeMethodInfoPtr_op_Implicit_Public_Static_RagdollBoneEntityElement_Entity_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(RagdollBoneEntityElement*) IL2CPP.il2cpp_object_unbox(num);
    }

    static RagdollBoneEntityElement()
    {
      Il2CppClassPointerStore<RagdollBoneEntityElement>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollBoneEntityElement));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollBoneEntityElement>.NativeClassPtr);
      RagdollBoneEntityElement.NativeFieldInfoPtr_Value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollBoneEntityElement>.NativeClassPtr, nameof (Value));
      RagdollBoneEntityElement.NativeMethodInfoPtr_op_Implicit_Public_Static_Entity_RagdollBoneEntityElement_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneEntityElement>.NativeClassPtr, 100683513);
      RagdollBoneEntityElement.NativeMethodInfoPtr_op_Implicit_Public_Static_RagdollBoneEntityElement_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RagdollBoneEntityElement>.NativeClassPtr, 100683514);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RagdollBoneEntityElement>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
