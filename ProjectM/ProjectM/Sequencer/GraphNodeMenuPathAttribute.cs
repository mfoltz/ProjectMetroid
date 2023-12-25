// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.GraphNodeMenuPathAttribute
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Sequencer
{
  public class GraphNodeMenuPathAttribute : Il2CppSystem.Attribute
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__Path;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Path_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

    public unsafe string Path
    {
      [CallerCount(8), CachedScanResults(RefRangeStart = 16442, RefRangeEnd = 16450, XrefRangeStart = 16442, XrefRangeEnd = 16450, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(GraphNodeMenuPathAttribute.NativeMethodInfoPtr_get_Path_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1090023, XrefRangeEnd = 1090035, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GraphNodeMenuPathAttribute(string path)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GraphNodeMenuPathAttribute>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(path);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(GraphNodeMenuPathAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static GraphNodeMenuPathAttribute()
    {
      Il2CppClassPointerStore<GraphNodeMenuPathAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (GraphNodeMenuPathAttribute));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GraphNodeMenuPathAttribute>.NativeClassPtr);
      GraphNodeMenuPathAttribute.NativeFieldInfoPtr__Path = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GraphNodeMenuPathAttribute>.NativeClassPtr, nameof (_Path));
      GraphNodeMenuPathAttribute.NativeMethodInfoPtr_get_Path_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeMenuPathAttribute>.NativeClassPtr, 100685879);
      GraphNodeMenuPathAttribute.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GraphNodeMenuPathAttribute>.NativeClassPtr, 100685880);
    }

    public GraphNodeMenuPathAttribute(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string _Path
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeMenuPathAttribute.NativeFieldInfoPtr__Path)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(GraphNodeMenuPathAttribute.NativeFieldInfoPtr__Path), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }
  }
}
